using System;
using System.Windows.Forms;

namespace FormEvent
{
    class MainApp : Form
    {
        public void MyMouseHandler(object sender , MouseEventArgs e)
        {
            //sender 어떤 객체가 이벤트 처리기를 호출 하였는지 -> Button? 
            // e -> 이벤트처리기. 
            Console.WriteLine($"Sender : {((Form)sender).Text}");
            Console.WriteLine($"X : {e.X}, y:{e.Y}");
            Console.WriteLine($"Button : {e.Button}, Click : {e.Clicks}");
        }

        public MainApp (string title)
        {
            this.Text = title;
            this.MouseDown += new MouseEventHandler(MyMouseHandler);
        }
        
        static void Main(string[] args)
        {
            Application.Run(new MainApp("Mouse Event Test"));
        }

    }

    
}