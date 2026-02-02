using System;
using System.Windows.Forms;

namespace SimpleWindow
{
    class MainApp : Form
    {
        static void Main(string[] args)
        {
            MainApp form = new MainApp();

            form.Click += new EventHandler(
                (sender,eventArgs)=>{
                    Console.WriteLine("Closing Window....");
                    Application.Exit();
                });
            Console.WriteLine("Starting Window Application....");

            Application.Run(form);

            Console.WriteLine("Exiting window application...");
        }
    }
}