using currency4;
using currency5;


namespace currency6
{
    public class PredictinData
    {

        public void reader()

        {

            string address = @"F:\currency data\time.text";
            StreamReader streader = new StreamReader(address);


            double line1 = Convert.ToDouble(streader.ReadLine()); double line2 = Convert.ToDouble(streader.ReadLine());
            double line3 = Convert.ToDouble(streader.ReadLine()); double line4 = Convert.ToDouble(streader.ReadLine());
            double line5 = Convert.ToDouble(streader.ReadLine()); 





            var plus = line1 + line2 + line3 + line4 + line5 ;
                     
                    
                      


            long average1 = Convert.ToInt32(plus) / 5;

                var currencyinfo = currencyprocess.currencyinformation();

                var q = currencyinfo.Result.high;
                var e = currencyinfo.Result.low;
                var r = q + e;
                var t = Convert.ToInt32(r) / 2;

                var m = t - average1;

                var predictonbuy = m + currencyinfo.Result.buy;




                var per = currencyinfo.Result.buy - predictonbuy;
                var pe = per / currencyinfo.Result.buy;
                var PE = pe * 100;



                Console.WriteLine("predicton  is:  {0}", predictonbuy);

                Console.WriteLine( "percentage error is: {0}  currently price is: {1}" , PE , currencyinfo.Result.buy);


            streader.Close();   
            }
      






    }
}
