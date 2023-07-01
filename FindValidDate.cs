namespace FindValidDate{
    
    class FindValidDate{
        public static void Main(string[] args)
        {
            int flag =0;
            Console.WriteLine("Enter String :");
            string str = Console.ReadLine();

            string[] substr = str.Split(' ');
            
            foreach( string s in substr)
            {
                if(s.Length<8 || s.Length>8){
                    continue;
                }
                else{
                    for(int i=0; i<s.Length;i++){
                        if(Convert.ToInt32(s[i])>57)
                        {
                            flag++;
                            break;
                        }
            
                    }

                    if(flag !=0)
                    {continue;}
                    else{
                        int month = Convert.ToInt32(s.Substring(0,2));
                        int date = Convert.ToInt32(s.Substring(2,2));
                        int year = Convert.ToInt32(s.Substring(4,4));

                        //checking for valid date
                        if((date>0 && date<32) && (month>0 && month<13) && (year>1900 && year<3000)){
                            Console.WriteLine($"Month : {month}, Date : {date}, Year : {year}");
                        }
                    }
                }
            }
        }
    }
}    