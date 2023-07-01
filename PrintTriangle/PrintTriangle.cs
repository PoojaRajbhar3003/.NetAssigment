namespace PrintTriangle{

    class PrintTriangle{
       
        static void Main(string[] args){
        
            int height, i,j,lft,rt;

            //taking height from user
            height = Convert.ToInt32(Console.ReadLine());

            rt= lft = height;
        
            for(i=1;i<=height;i++)
            {
                for(j=1;j<(height*2);j++){
                    if(j<lft||j>rt){
                        Console.Write(" ");
                    }
                    else{
                        Console.Write("*");
                    }
                }
                lft--;
                rt++;
                Console.WriteLine("\n");
            }    

        }
    
    }
}