using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
//using clrss;

namespace Console_dll
{
    class Program
    {
        /*
        //Опишем функцию, которую будем вызывать из DLL
        [DllImport("clrss.dll", EntryPoint = "Class1.owner")]
                //public static extern int MessageBox(int hWnd, string text, string caption, uint type);
        public static extern string owner(string FileName);

        [DllImport("clrss.dll", EntryPoint = "Class1.ownerEx")]
        public static extern string ownerEx(string FileName);


        [DllImport("clrss.dll", EntryPoint = "Class1.Title_Ex")]
        public static extern string Title_Ex(string FileName);


            */
        [DllImport("clr_saop.dll", EntryPoint = "clr_saop.Get_XML.get_stavka_ref")]
        public static extern string get_stavka_ref();
        

        [DllImport("clrdadata.dll", EntryPoint = "std1.standart")]
        public static extern int standart(string s);

        [DllImport("clrdadata.dll", EntryPoint = "std1.fias_adr")]
        public static extern int fias_adr(string s);

        [DllImport("ya_geocode.dll", EntryPoint = "ya.yageo")]
        public static extern string yageo(string s, string s1);
        [DllImport("ya_geocode.dll", EntryPoint = "ya.yageo_XY")]
        public static extern string yageo_XY(string adr);


        [DllImport("clr_postr.dll", EntryPoint = "clr_postr.trackingN")]
        public static extern string trackingN(string s);



        [DllImport("fsspchk_clr.dll", EntryPoint = "fsspchk_clr.fsspchk")]
        // public static extern string fsspchk(string f, string i, string o, string region, int idp, string bd);
        public static extern string fsspchk(int typ, int idp, string f = null, string i = null, string o = null, string region = null, string bd = null, string IP = null, int delay = 5, int num = 5);

        [DllImport("fsspchk_clr.dll", EntryPoint = "fsspchk_clr.fsspchk_task")]
        public static extern string fsspchk_task(int idp, string t, int delay=5);
        
        [DllImport("fsspchk_clr.dll", EntryPoint = "fsspchk_clr.fsspchk_p")]
        // public static extern string fsspchk(string f, string i, string o, string region, int idp, string bd);
        public static extern void fsspchk_p(int typ, int delay = 5, int num = 5);

        [DllImport("fsspchk_clr.dll", EntryPoint = "fsspchk_clr.fsspchk_task_p")]
        public static extern void fsspchk_task_p(int typ, string _token, int delay = 5, int num = 5);




        ////////////profidata
        /*
        [DllImport("fsspchk_clr_profidata.dll", EntryPoint = "fsspchk_clr_profidata.fsspchk")]
        public static extern string fsspchk1(int typ, int idp, string f = null, string i = null, string o = null, string region = null, string bd = null, string IP = null, int delay = 5, int num = 5);

        [DllImport("fsspchk_clr_profidata.dll", EntryPoint = "fsspchk_clr_profidata.fsspchk_task")]
        public static extern string fsspchk_task1(int idp, string t, int delay = 5);
        */
        [DllImport("fsspchk_clr_profidata.dll", EntryPoint = "fsspchk_clr_profidata.fsspchk_p")]
        // public static extern string fsspchk(string f, string i, string o, string region, int idp, string bd);
        public static extern void fsspchk_p(int typ, string _token, int delay = 5, int num = 5);
       

        //////////////profixd
        


        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        [DllImport("sms_api.dll", EntryPoint = "sms_stat_clr.sms_stat")]
        public static extern string sms_stat(string login, string pass, string d1, string d2);
        [DllImport("sms_api.dll", EntryPoint = "sms_stat_clr.getstatusSms")]
        public static extern void getstatusSms(string login, string pass, int id);

        [DllImport("sms_api.dll", EntryPoint = "sms_stat_clr.getstatusSmsList")]
        public static extern void getstatusSmsList();
        

        [DllImport("bankrot_clr.dll", EntryPoint = "bankrot_req_clr.bnkt_req")]
        //   public static extern string bnkt_req(string pid, int type, string sdt,  char[] Wpath  = null);
        public static extern string bnkt_req(string pid, int type, string sdt, string Wpath = null);


        /// <summary>
        /// ///////////////////////////////////////////   Fedres
        /// </summary>
        /// <param name="dstart"></param>
        /// <param name="dend"></param>
        /// <returns></returns>
        //           Fedres
        /*
        [DllImport("fedresursX_clr.dll", EntryPoint = "fedresursX_clr")]
        
        public static extern string GDBLPP(string dstart, string dend);
        */
        /// <summary>
        /// ///////////////////////  Fedres profidata
        /// </summary>
        /// <param name="dstart"></param>
        /// <param name="dend"></param>
        /// <returns></returns>
        [DllImport("fedresursX_clr_profidata.dll", EntryPoint = "fedresursX_clr_profidata")]

        public static extern string GDBLPP(string dstart, string dend, string suf);


        /// <summary>
        /// sudrf
        /// </summary>
        /// <param name="args"></param>


        [DllImport("sudrf_clr.dll", EntryPoint = "sudRf_clr_frmwrk.sudrf.sudrf_clr")]

        public static extern void sudrf_1();


        static void Main(string[] args)
        {


            //sudRf_clr_frmwrk.sudrf.sudrf_clr();


            /*

            string s1 = "с - з 'Чкаловский' Оренбургского р-на #Оренбургской обл.";


            s1 = Regex.Replace(s1, "[\x27|\x23]", "");
            */

            //Эта функция будет вызвана из DLL
            // string s = new string(args[1]);
            //   Console.WriteLine(Class1.owner(args[0]));
            //               Console.WriteLine(Class1.ownerEx(args[0]));


            // --------------------------------------clrdadata.dll-------------------------------------------------
            // Console.WriteLine(std1.standart("194044, Санкт-Петербург г, Город САНКТ-ПЕТЕРБУРГ, СМОЛЯЧКОВА, д. 7, кв. 8".ToString()));
              //         Console.WriteLine(std1.standart("Санкт-Петербург, Шевченко 7а".ToString()));


            // Console.WriteLine(std1.fias_adr("3012e1c5-3a46-4684-b1a3-7ba4eed6b353", "region_kladr_id"));
            // Console.WriteLine(std1.fias_adr("2200000400000030022"));



            // Заголовок Excel
            //Console.WriteLine(Class1.Title_Ex(args[0]));

            // Адрес по координатам
            //         Console.WriteLine(ya.yageo_XY("Спб 8-я Красноармейская д 23"));


            // Ставка рефинансирования
            //       Console.WriteLine(Get_XML.get_stavka_ref());


            // Почтовые отправления

            // Console.WriteLine(clr_postr.trackingN("19085535958772"));

            ////////////////////////////////////////////fedres
              fedresursX_clr.GDBLPP("2021-03-29", "2021-04-01", "0");
              // fedresursX_clr.GDMCFPBIdBankrupt(479597, "0", "04.11.2012");
            


            //    exec profidata.[db_mess_bankruptcy].dbo.[DebtorIdBankrupt] 74907,0 ,'01.01.2014'



            /////////////////////////////////////////////////////////////////////////////////////////            // Запрос в ФССП
            //
            string s = @"{     ""token"": ""mi9zoX217Ult"",     ""request"": [       { ""type"": 1,     ""params"": {" +
@"""firstname"": ""Магомедсаид""," +
          @"""lastname"": ""Магомедов""," +
          @"""region"": 78   }}," +

    @"{   ""type"": 1,     ""params"": {" +
        @"""firstname"": ""Ольга"", " +
          @"""lastname"": ""Козулина""," +
          @"""region"": 47 }}," +

      @" { ""type"": 1,     ""params"": {" +

          @"""firstname"": ""Сергей""," +
          @"""lastname"": ""Мучинский""," +
          @"""region"": 78 }}" +
        "  ]   }";

            // var json1 = JObject.Parse(s);

            //  fsspchk_clr.fsspchk_task_p("0124ddb6-9de7-4595-b758-1358ba73629a", 2, 2, 2);

               // fsspchk_clr_profidata.fsspchk_p(1, "WeZEzw88Onwe", 2, 2);
            

            //   fsspchk_clr_profidata.fsspchk_task_p("8a155ed8-0bef-488f-81d4-d0db2987bc5c", 1, 2, 2);


            //     fsspchk_clr_profidata.fsspchk_p(1, 2, 1);


            //      fsspchk_clr_profixd.fsspchk_p(1, 2, 2);



            /*
            

          r = fsspchk_clr.fsspchk(1, 989011, IP: "72498/17/78001-ИП");

          r = fsspchk_clr.fsspchk(0, 14299, f:"Парфенов", i: "Игорь", o: "Александрович",region: "3", bd: "18.10.1983");
          */

            //   r =  fsspchk_clr.fsspchk(f: "Барышникова", i: "Анна", o: "Николаевна", bd: "30.03.1985", idp: 989011, region:"76");
            //fsspchk_clr.fsspchk(f: "ИВАНОВ", i: "ВЛАДИМИР", o: "АЛЕКСАНДРОВИЧ", bd: "31.01.1982", idp: 902389, region: "78");

            //       r = fsspchk_clr.fsspchk_task(14299, "8d01efec-60f6-4855-b716-388fd0faff0d");

            /*
             login=centrepro
        password=1419623
            */


            // string     r = sms_stat_clr.sms_stat("centrepro", "1419623", "2019-12-01", "2019-12-31");
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////sms_stat_clr.getstatusSms("centrepro", "1419623", 595758861);
            //     sms_stat_clr.getstatusSmsList();
            //      sms_stat_clr.getstatusSms("centrepro", "1419623", "4347456657000077028");


            ///////////////////// Банкротство
            //   StringBuilder Wpath1 = new StringBuilder();
            //  Wpath1.Insert(0, @"C:\TEMP");
            // char[] p = new [] { 'C',':','\\','t','E','M','P' };
            ///////////////////////////////////////////////////////////////// dadata

            ///////////////////////////////////////////////////////////////////
            // bankrot_req_clr.bnkt_req("584995", 1, "А65-11464/2017", Wpath: "\\\\profiserver\\obmen$\\4. Управления и отделы\\4.07. УИТ\\bankruptcy_test");
            //bankrot_req_clr.bnkt_req("511651", 2, "701738714000", Wpath: "\\\\profiserver\\obmen$\\4. Управления и отделы\\4.07. УИТ\\bankruptcy_test");

            // 1328553 0 666700379439 \\profiserver\obmen$\4.Управления и отделы\4.07.УИТ\bankruptcy_test
            // 893310 2 344200201330 O:\4.Управления и отделы\4.07.УИТ\1.5.19.Михаил\bankruptcy
            // 666700379439

        }
    }
}
