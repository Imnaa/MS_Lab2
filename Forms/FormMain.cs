using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace MS_Lab2
{
    public partial class FormMain : Form
    {
        double t0 = 0; // стартовое время системы (мин)
        double dt = 0; // приращение времени  (мин)

        double t1 = 5; // время для 1 детали (мин)
        double t2 = 20; // время для 2 детали (мин)
        double t3 = 10; // время для сборки (мин)

        /// <lab2_init_values>
        /// 
        const int m1 = 5; // для t1
        const int sigma1 = 1; // для t1
        const double lyambda2 = 0.05f; // для t2
        // Для бракованных деталей
        /// Интервал раброса: [0...2]
        const int Ymin = 0;
        const int Ymax = 2;
        int Nbr_Section1 = 0; // кол-во бракованных отправилось в секцию 1
        int Nbr_Section2 = 0; // кол-во бракованных отправилось в секцию 2
        int Nbr = 0; // кол-во бракованных всего
        /// 
        /// </lab2_init_values>

        const int N1 = 5; // шт. деталей выплевывается из 1 блока
        const int N2 = 20; // шт. деталей выплевывается из 2 блока
        const int N3 = 10;  // шт. деталей надо для конвейера

        // Инициализация главной формы
        public FormMain()
        {
            InitializeComponent();
        }
        // Обработка кнопки "Выход" на 1 вкладке
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Конец модуляции наступает, когда пройдут 1 сутки
        // 24 часа * 60 мин
        double isTimeOut = 24f*60f;


        // Начать моделирование
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            // Запоминаем время.
            double _t1 = t1;
            double _t2 = t2;
            double _t3 = t3;
            
            // Обнуление переменных
            t0 = 0; // стартовое время системы (мин)

            //_t1 = 5; // время для 1 детали (мин)
            //_t2 = 20; // время для 2 детали (мин)
            //_t3 = 10; // время для сборки (мин)

            // Очередь 1
            int queue1 = 0;
            // Очередь 2
            int queue2 = 0;
            // Комплектация 
            int equipment = 0;
            // Наличие деталей в 1 секции 
            int countSection1 = 0;
            // Наличие деталей во 2 секции 
            int countSection2 = 0;
            // Сборка свободна
            bool isEquipmentFree = true;
            // Время завершения сборки
            double tFinish = 0;

            //////////////////
            ///
            /// Показатели работы:
            ///
            //////////////////

            // Таймер
            var timer = Stopwatch.StartNew();
            // Средняя производительность конвейера
            double avgMakeDetal = 0;
            // Полное время простоя конвейера из-за незаполненности секций
            double fullIdleTimeConveyor = 0;
            // Средние и максимальное очереди по каждому типу изделия
            double avgQueue1 = 0;
            double maxQueue1 = 0;
            double minQueue1 = 0;
            double avgQueue2 = 0;
            double maxQueue2 = 0;
            double minQueue2 = 0;
            // Для среднего значения:
            List<int> queue1Elems = new List<int>();
            List<int> queue2Elems = new List<int>();

            // Создание объекта для работы с законами
            Zakoni zakoni = new Zakoni();

            // Начало модуляции
            while (t0 <= isTimeOut)
            {
                // УЗ 1
                if (t0 >= _t1)
                {
                    // Суем в очередь изготовленные детали 1 типа
                    queue1 += N1;
                    // Используем закон по варианту для именения времени
                    t1 = zakoni.GetNormal(m1, sigma1);
                    // Считаем следующее время для изготовление детали 1 типа
                    _t1 = t0 + t1;
                    // Вычисляем dt
                    dt = updateValueDt();
                    updateDgvReportT1();
                }
                // УЗ 2
                if (t0 >= _t2)
                {
                    // Суем в очередь изготовленные детали 1 типа
                    queue2 += N2;
                    // Используем закон по варианту для именения времени
                    t2 = zakoni.GetExp(lyambda2);
                    // Считаем следующее время для изготовление детали 1 типа
                    _t2 = t0 + t2;
                    // Вычисляем dt
                    dt = updateValueDt();
                    updateDgvReportT2();
                }
                // УЗ 3
                if ((queue1 > 0 && countSection1 < N3) || (queue2 > 0 &&  countSection2 < N3))
                {
                    // Если в очереди 1 есть что-то и в конвейере меньше N3 деталей, то кидаем детали в конвейер
                    if (queue1 > 0 && countSection1 < N3)
                    {
                        do
                        {
                            ++countSection1;
                            --queue1;
                        } while (queue1 > 0 && countSection1 != N3);
                    }
                    // Если в очереди 2 есть что-то и в конвейере меньше N3 деталей, то кидаем детали в конвейер
                    if (queue2 > 0 && countSection2 < N3)
                    {
                        do
                        {
                            ++countSection2;
                            --queue2;
                        } while (queue2 > 0 && countSection2 != N3);
                    }
                }
                // УЗ 4
                if (countSection1 == N3 && countSection2 == N3 && isEquipmentFree)
                {
                    // Сборка занята
                    isEquipmentFree = false;
                    // Рассчет времени завершения
                    tFinish = t0 + t3;
                    // Забираем все детали из конвейера
                    countSection1 = 0;
                    countSection2 = 0;
                }
                // УЗ 5
                if (tFinish >= t0 && tFinish < (t0 + dt) && t0 != 0f)
                {
                    // Создаем новую вещь
                    ++equipment;
                    // Сборка свободна
                    isEquipmentFree = true;
                }
                // Вычисление простоя конвейера
                if (countSection1 == 0 || countSection2 == 0)
                {
                    fullIdleTimeConveyor += dt;
                }
                // Вычисление max/min/avg очередей
                if (countSection1 == N3)
                {
                    maxQueue1 = Math.Max(maxQueue1, queue1);
                    minQueue1 = Math.Min(minQueue1, queue1);
                    queue1Elems.Add(queue1);
                }
                if (countSection2 == N3)
                {
                    maxQueue2 = Math.Max(maxQueue2, queue2);
                    minQueue2 = Math.Min(minQueue2, queue2);
                    queue2Elems.Add(queue2);
                }

                // добавление в dgv инфы
                int rowNumber = dgv.Rows.Add();
                dgv.Rows[rowNumber].Cells["time"].Value = t0;
                dgv.Rows[rowNumber].Cells["queue1"].Value = queue1;
                dgv.Rows[rowNumber].Cells["queue2"].Value = queue2;
                dgv.Rows[rowNumber].Cells["countSection1"].Value = countSection1;
                dgv.Rows[rowNumber].Cells["countSection2"].Value = countSection2;
                dgv.Rows[rowNumber].Cells["isEquipmentFree"].Value = !isEquipmentFree;
                dgv.Rows[rowNumber].Cells["equipment"].Value = equipment;

                // Прибавление времени
                t0 += dt;
                // ProgressBar
                if (Convert.ToInt32(dt) < progressBar1.Maximum)
                {
                    progressBar1.Value = Convert.ToInt32((t0 / isTimeOut) * 100);
                }
            }
            // ProgressBar max
            progressBar1.Value = progressBar1.Maximum;
            // Остановка таймера
            timer.Stop();
            // Показ на форме
            textBoxTime.Text = String.Format("{0:0.00}", ((double)timer.ElapsedMilliseconds) / 1000 / 60); // в минутах

            // Средняя производительность конвейера
            avgMakeDetal = (double)equipment / (t0 / 60f / 24f); // деталей в сутки
            // Запись на форму
            textBoxAvgSpeed.Text = avgMakeDetal.ToString();

            // Полное время простоя конвейера
            textBoxConeyorIdle.Text = fullIdleTimeConveyor.ToString();

            // Средние и максимальное очереди по каждому типу изделия
            textBoxMaxTimeIdleQueue1.Text = maxQueue1.ToString();
            textBoxMaxTimeIdleQueue2.Text = maxQueue2.ToString();
            textBoxMinTimeIdleQueue1.Text = minQueue1.ToString();
            textBoxMinTimeIdleQueue2.Text = minQueue2.ToString();
            // Среднее значение:
            foreach (int q in queue1Elems)
            {
                avgQueue1 += q;
            }
            foreach (int q in queue2Elems)
            {
                avgQueue2 += q;
            }
            avgQueue1 /= (double)queue1Elems.Count;
            avgQueue2 /= (double)queue1Elems.Count;
            // Вывод в форму
            textBoxAvgSpeedQueue1.Text = avgQueue1.ToString();
            textBoxAvgSpeedQueue2.Text = avgQueue2.ToString();
        }
        // Выход из программы
        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Вычисление dt
        private double updateValueDt()
        {
            // Сортируем времена по возрастанию
            List<double> list = new List<double>();
            list.Add(t1);
            list.Add(t2);
            list.Add(t3);
            list.Sort();

            return list[0] / 10; // делим наименьшее время на 10 (так надо)
        }
        // Обновление всех необходимых переменных
        private void updateAllValues()
        {
            Zakoni zakoni = new Zakoni();
            t1 = zakoni.GetNormal(m1, sigma1);
            t2 = zakoni.GetExp(lyambda2);

            dt = updateValueDt();

            textBoxT1.Text = t1.ToString();
            textBoxT2.Text = t2.ToString();
            textBoxT3.Text = t3.ToString();
            textBoxN1.Text = N1.ToString();
            textBoxN2.Text = N2.ToString();
            textBoxN3.Text = N3.ToString();

            updateDgvReportT1();
            updateDgvReportT2();

            // здесь мб вызов случайного процесса

            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
        }
        // Вызов случайного процесса
        private void callRandomProcess()
        {
            ParamsKorrelutionFunctions paramsKorrelutionFunctions = new ParamsKorrelutionFunctions();
            paramsKorrelutionFunctions.FindA(Ymax, Ymin);
            paramsKorrelutionFunctions.FindB(dt);
            paramsKorrelutionFunctions.Ky_x4dt(dt, 2 * dt, 3 * dt, 4 * dt);
            paramsKorrelutionFunctions.findConstants();

            double[] rndPoisson = paramsKorrelutionFunctions.MethodMovingSumm();

            Nbr_Section1 = 0;
            textBoxNbrFromSection1.Text = Nbr_Section1.ToString();

            Nbr_Section2 = 0;
            textBoxNbrFromSection2.Text = Nbr_Section2.ToString();

            textBoxNbr.Text = Nbr.ToString();
        }

        private void buttonRandomValues_Click(object sender, EventArgs e)
        {
            updateAllValues();
        }
        // Обновление dgvReportT1 (lab2)
        private void updateDgvReportT1()
        {
            int rowNumber = dgvReportT1.Rows.Add();
            dgvReportT1.Rows[rowNumber].Cells["ColumnT1"].Value = t1;
        }
        // Обновление dgvReportT2 (lab2)
        private void updateDgvReportT2()
        {
            int rowNumber = dgvReportT2.Rows.Add();
            dgvReportT2.Rows[rowNumber].Cells["ColumnT2"].Value = t2;
        }
    }
}
