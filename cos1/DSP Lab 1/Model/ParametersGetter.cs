using System;
using System.Windows.Forms;

namespace DSP.Lab1.Presentation.Model
{
    public static class ParametersGetter
    {
        public static ParametersModel Get1a(Form1 form)
        {
            var result = new ParametersModel();
            
            while(form.NComboBox.Text == "")
            {
                MessageBox.Show("N connot be empty");
                form.NComboBox.Text = "512";

            }
                
            result.N = Convert.ToInt32(form.NComboBox.Text);

            while (form.A1TextBox.Text == "")
            {
                MessageBox.Show("A connot be empty");
                form.A1TextBox.Text = "1";

            }
            result.A[0] = Convert.ToDouble(form.A1TextBox.Text);
            while (form.F1TextBox.Text == "")
            {
                MessageBox.Show("F connot be empty");
                form.F1TextBox.Text = "1";

            }
            result.F[0] = Convert.ToDouble(form.F1TextBox.Text);
            try
            {
                result.WellRate = Convert.ToDouble(form.WellRateValuelabel.Text);
            }
            catch { result.WellRate = 0; }
            return result;
        }

        public static ParametersModel Get1b(Form1 form)
        {
            var result = new ParametersModel();
            result.N = Convert.ToInt32(form.NComboBox.Text);
            result.A[0] = Convert.ToDouble(form.A1TextBox.Text);
            result.A[1] = Convert.ToDouble(form.A2TextBox.Text);
          
            result.F[0] = Convert.ToDouble(form.F1TextBox.Text);
            result.F[1] = Convert.ToDouble(form.F2TextBox.Text);
            
            result.Fi[0] = Math.PI / Convert.ToDouble(form.Fi1TextBox.Text);
            result.Fi[1] = Math.PI / Convert.ToDouble(form.Fi2TextBox.Text);
            
            try
            {
                result.WellRate = Convert.ToDouble(form.WellRateValuelabel.Text);
            }
            catch { result.WellRate = 0; }
            return result;
        }

        public static ParametersModel Get1c(Form1 form)
        {
            var result = new ParametersModel();
            result.N = Convert.ToInt32(form.NComboBox.Text);
            result.A[0] = Convert.ToDouble(form.A1TextBox.Text);
            result.F[0] = Convert.ToDouble(form.F1TextBox.Text);
            result.A[1] = Convert.ToDouble(form.A2TextBox.Text);
            result.F[1] = Convert.ToDouble(form.F2TextBox.Text);
            result.Fi[0] = Convert.ToDouble(form.Fi1TextBox.Text);
            result.Fi[1] = Convert.ToDouble(form.Fi2TextBox.Text);
            try
            {
                result.WellRate = Convert.ToDouble(form.WellRateValuelabel.Text);
            }
            catch { result.WellRate = 0; }
            return result;
        }

        
    }
}
