using System;
using System.IO;

namespace BoilerEventApp1
{
    class Boiler{
        private int temp;
        private int pressure;
        public Boiler(int t, int p){
            temp = t;
            pressure = p;
        }
        public int getTemp(){
            return temp;
        }
        public int getPressure(){
            return pressure;
        }
    } // Boiler类
    class DelegateBoilerEvent{
        public delegate void BoilerLogHandler(string status);

        // 基于上面的委托定义事件
        public event BoilerLogHandler BoilerEventLog;
        public void LogProcess()
        {
            string remarks = "O. K";
            Boiler b = new Boiler(130, 14);
            int t = b.getTemp();
            int p = b.getPressure();
            if (t > 150 || t < 80 || p < 12 || p > 15)
            {
                remarks = "Need Maintenance";
            }
            OnBoilerEventLog("\n----------------------------\n\nLogging Info:\n");
            OnBoilerEventLog("Temparature " + t + "\nPressure: " + p);
            OnBoilerEventLog("\nMessage: " + remarks);
        }
        protected void OnBoilerEventLog(string message){
            if (BoilerEventLog != null)
            {
                BoilerEventLog(message);
            }
        }
    } // 事件发布器
    class BoilerInfoLogger{
        FileStream fs;
        StreamWriter sw;
        public BoilerInfoLogger(string filename)
        {
            fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
        }
        public void Logger(string info){
            sw.WriteLine(info);
        }
        public void Close(){
            sw.Close();
            fs.Close();
        }
    } // 该类保留写入日志文件的条款
    public class RecordBoilerInfo{
        static void Logger(string info){
            System.Console.WriteLine(info);
        } // end of Logger
        static void Main(string[] args){
            BoilerInfoLogger filelog = new BoilerInfoLogger("boiler.txt");
            DelegateBoilerEvent boilerEvent = new DelegateBoilerEvent();
            boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHandler(Logger);
            boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHandler(filelog.Logger);
            boilerEvent.LogProcess();
            Console.ReadLine();
            filelog.Close();
        } // end of main
    } // 事件订阅器
}
