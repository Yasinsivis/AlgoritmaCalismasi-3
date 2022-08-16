int mevcut=0;
            Console.Write("Kaç Eleman Girmek İstiyorsunuz: ");
            mevcut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            string[] Person = new string[mevcut];
 
            for(int i=0;i<mevcut;i++)
            {
                Console.Write((i+1)+"."+"Eleman Adını Giriniz : ");
                Person[i]=Console.ReadLine();
           
                
            }
            Array.Reverse(Person);
            foreach (var pers in Person)
            {
                Console.WriteLine(pers);
            }
       
        
 
         
