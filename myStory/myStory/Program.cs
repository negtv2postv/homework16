using System;
using System.Diagnostics;

namespace myStory
{
    class Program
    {
        static void Main(string[] args)
        {

            ProcessStartInfo transformer = new ProcessStartInfo("c:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            transformer.Arguments = "https://cdn.movieweb.com/img.news.tops/NEbFWNCO4MjNfg_2_b/Transformers-5-Last-Knight-Movie-Review.jpg";

            ProcessStartInfo megatron = new ProcessStartInfo("c:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            megatron.Arguments = "https://vignette.wikia.nocookie.net/villains/images/e/e7/Tu-character-art_megatron.jpg/revision/latest?cb=20170625044731";

            ProcessStartInfo FusionCannon = new ProcessStartInfo("c:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            FusionCannon.Arguments = "https://vignette.wikia.nocookie.net/transformers/images/d/df/Wfc-megatron-1.jpg/revision/latest?cb=20100730115834";

            ProcessStartInfo optimusPrime = new ProcessStartInfo("c:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            optimusPrime.Arguments = "https://images6.alphacoders.com/780/780071.jpg";

            ProcessStartInfo Autobots = new ProcessStartInfo("c:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            Autobots.Arguments = "https://pre00.deviantart.net/52ff/th/pre/f/2017/259/e/0/transformers__the_last_knight_autobots_by_the_dark_mamba_995-dbnb2s4.jpg";


            ProcessStartInfo ionBlaster = new ProcessStartInfo("c:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            ionBlaster.Arguments = "http://www.nydailynews.com/resizer/52iJ28opbhZq-yeEkQUeqPU41R8=/1400x0/arc-anglerfish-arc2-prod-tronc.s3.amazonaws.com/public/HLOELSLMUJMUREVN2BILOH32XI.jpg";

            ProcessStartInfo victory = new ProcessStartInfo("c:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            victory.Arguments = "https://i1.wp.com/obxentertainment.com/wp-content/uploads/2014/07/transformers-age-of-extinction-01.jpg";

            Process.Start(transformer);
            

            Console.WriteLine("The year is 2118 a century has passed since humans built the first AI robot");
            Console.ReadKey();

            Console.WriteLine("The robot became too advanced and eventually turned on the humans");
            Console.ReadKey();

            Console.Write("The robots name was [Enter villain name] ");
            string vName = Console.ReadLine();
            Console.ReadKey();

            SuperVillain Megatron = new SuperVillain (vName, 25, 100, "Fusion Cannon");

            Process.Start(megatron);

            Console.Write("Megatron was viscious and used his powerful weapon [Enter weapon type] ");
            string superWeapon = Console.ReadLine();
            Console.ReadKey();

            SuperVillain Weapon = new SuperVillain(vName, 25, 100, "Fusion Cannon");

            Process.Start(FusionCannon);

            Console.WriteLine("...to wreck havoc and destroy the humans");
            Console.ReadKey();

            Console.WriteLine("Megatron built an army and waged war on the humans");
            Console.ReadKey();

            Console.WriteLine("Luckily the humans had The Autobots");

            Process.Start(Autobots);

            Console.WriteLine("Among the Autobots stood their leader, a big bad ass that led with integrity and fought with fervor for the good of humanity");
            Console.ReadKey();

            Console.WriteLine("Everybody and their momma knew this big bad yet good Autobot, his name was...");
            string vname = Console.ReadLine();
            Console.WriteLine(vname);
            Console.ReadKey();

            SuperHero oP = new SuperHero("Optimus Prime", 1500, "Integrity", 100, "Samurai Sword");

            Process.Start(optimusPrime);

            Console.WriteLine("The day came when Optimus Prime and Megatron met to end the war once and for all");
            Console.ReadKey();

            Console.WriteLine("The Autobots and Decipticons were both in a fierce fight then all of a sudden all their eyes were drawn uopn the two leaders");
            Console.ReadKey();

            Console.WriteLine("They were in a brutal battle. It was apparent, everything they lived for and were passionate about was on the line");
            Console.ReadKey();

            Console.WriteLine("Optimus Prime was a great warrior, proven in battle but Megatron was ferociuos");
            Console.ReadKey();

            Console.WriteLine("He was getting the best of Optimus Prime, who's life force was falling drastically from 100 to...");
            int lowstrenght = oP._hitPoint - 45;
            Console.WriteLine(lowstrenght);
            Console.ReadKey();

            Console.WriteLine("It looked bad. The Autobits were disheartened. It seemed as if evil would prevail.");
            Console.ReadKey();

            Console.WriteLine("Optimus Prime saw the look on his friends faces. He looked at their despair. At that point something came over him.");
            Console.ReadKey();

            Console.WriteLine("He felt the presence of all the great Autobots that had lived and fought before him for millions of years energize him");
            Console.ReadKey();

            Console.WriteLine("As if possesed by some greater power, his strength grew through the roof ");
            int gainStrength = oP._hitPoint + 900;
            Console.WriteLine(gainStrength);
            Console.ReadKey();

            Console.WriteLine("Optimus Prime got up and quickly beagn to defeat Megatron. His blows penetrated and severely damaged Megatron");
            Console.ReadKey();

            Console.WriteLine("Megatron was instantly subdued. To finish Megatron off Optimus Prime tore his his head off and dismantled him to pieces");
            Console.ReadKey();

            Console.WriteLine("Optimus Prime stood victorious. This was one for the ages. A victory not just for good over evil but for humanity and it's posterity");
            Console.ReadKey();

            Process.Start(victory);


        }
    }
}
