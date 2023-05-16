using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4._2
{
    public partial class Form1 : Form
    {
        Model model;

        public Form1()
        {
            InitializeComponent();
            model = new Model();
            model.observer += new System.EventHandler(this.UpdateFromModel);
        }

        private void labelA_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateFromModel(this, e);
        }

        private void textBox_A_TextChanged(object sender, EventArgs e)
        {

        }



        //A

        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {
            model.setA(Decimal.ToInt32(numericUpDownA.Value));

            //trackBaraA.Value = Decimal.ToInt32(numericUpDownA.Value);
            //textBox_A.Text = numericUpDownA.Value.ToString();
        }

        private void trackBaraA_Scroll(object sender, EventArgs e)
        {
            model.setA(trackBaraA.Value);
            //numericUpDownA.Value = trackBaraA.Value;
        }

        private void textBox_A_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setA(Int32.Parse(textBox_A.Text));
        }

        //B

        private void textBox_B_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownB_ValueChanged(object sender, EventArgs e)
        {
            model.setB(Decimal.ToInt32(numericUpDownB.Value));
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            model.setB(trackBarB.Value);
        }

        private void textBox_B_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setB(Int32.Parse(textBox_B.Text));
        }

        //C

        private void textBox_C_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownC_ValueChanged(object sender, EventArgs e)
        {
            model.setC(Decimal.ToInt32(numericUpDownC.Value));
        }

        private void trackBarC_Scroll(object sender, EventArgs e)
        {
            model.setC(trackBarC.Value);
        }

        private void textBox_C_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setC(Int32.Parse(textBox_C.Text));
        }



        //метод обновления модели
        private void UpdateFromModel(object sender, EventArgs e)
        {
            numericUpDownA.Value = model.GetA();
            numericUpDownB.Value = model.GetB();
            numericUpDownC.Value = model.GetC();
            textBox_A.Text = model.GetA().ToString();
            textBox_B.Text = model.GetB().ToString();
            textBox_C.Text = model.GetC().ToString();
            trackBaraA.Value = model.GetA();
            trackBarB.Value = model.GetB();
            trackBarC.Value = model.GetC();
        }
        //метод сохранения значений A и C при закрытии формы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.value_A = trackBaraA.Value;
            Properties.Settings.Default.value_C = trackBarC.Value;
            Properties.Settings.Default.Save();
        }
    }

    public class Model
    {
        private int A, B, C;
        public System.EventHandler observer;
        public Model() {
            A = Properties.Settings.Default.value_A;
            B = A;
            C = Properties.Settings.Default.value_C;
        }
        public void setA(int a)
        {
            if (a > C)
            {
                observer.Invoke(this, null);
                return;
            }
            if (a > B && a <= C)
                B = a;
            A = a;
            observer.Invoke(this, null);
        }
        public void setB(int b)
        {
            if (b > C || b < A)
            {
                observer.Invoke(this, null);
                return;
            }
            B = b;
            observer.Invoke(this, null);
        }
        public void setC(int c)
        {
            if (c < A)
            {
                observer.Invoke(this, null);
                return;
            }
            if (c < B)
                B = c;
            C = c;
            observer.Invoke(this, null);
        }
        public int GetA()
        {
            return A;
        }
        public int GetB()
        {
            return B;
        }
        public int GetC()
        {
            return C;
        }
    }
}
