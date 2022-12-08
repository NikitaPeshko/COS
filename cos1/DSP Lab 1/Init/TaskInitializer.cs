namespace DSP.Lab1.Presentation.Init
{
    public static class TaskInitializer
    {
        private static void InitAllParameters(Form1 form)
        {
            form.A1TextBox.Enabled = false;
            form.A2TextBox.Enabled = false;
        
            form.F1TextBox.Enabled = false;
            form.F2TextBox.Enabled = false;

            form.Fi1TextBox.Enabled = false;
            form.Fi2TextBox.Enabled = false;
    
        
            

            




            form.ModulationComboBox.Enabled = false;
            form.ModulatingSignalComboBox.Enabled = false;
        }

        public static void InitTask1A(Form1 form)
        {
            InitAllParameters(form);
            form.A1TextBox.Enabled = true;
            form.F1TextBox.Enabled = true;
            
            
        }

        public static void InitTask1B(Form1 form)
        {
            InitAllParameters(form);
           
            form.ModulatingSignalComboBox.Enabled = true;
            form.A1TextBox.Enabled = true;
            form.A2TextBox.Enabled = true;
          
            form.F1TextBox.Enabled = true;
            form.F2TextBox.Enabled = true;
          
            form.Fi1TextBox.Enabled = true;
            form.Fi2TextBox.Enabled = true;
      
        }

        public static void InitTask1C(Form1 form)
        {
            InitAllParameters(form);
            form.A1TextBox.Enabled = true;
            form.F1TextBox.Enabled = true;
            form.A2TextBox.Enabled = true;
            form.F2TextBox.Enabled = true;
            
            form.Fi1TextBox.Enabled = true;
            form.Fi2TextBox.Enabled = true;

            form.ModulationComboBox.Enabled = true;
            form.ModulatingSignalComboBox.Enabled = true;
        }

       

       
       
      

        
    }
}
