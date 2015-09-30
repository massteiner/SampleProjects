using System;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 1 && args[0] == "linux")
        {
            DrawLinux();
        }
        else if (args.Length == 1 && args[0] == "freebsd")
        {
            DrawFreeBSD();
        }
        else if (args.Length == 1 && args[0] == "mac")
        {
            DrawMac();
        }
        //  else if (args.Length == 1 && args[0] == "bbv")
        //  {
        //      DrawBbv();
        //  }
        else
        {
            DrawWindows();
        }

        Console.WriteLine();
        Console.WriteLine("Press ENTER to exit ...");
        Console.ReadLine();
    }


    private static void DrawWindows()
    {
        Console.WriteLine("Hello, Windows...");

        const int squareSize = 20;

        var colors = new[] { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Yellow };
        for (int row = 0; row < 2; row++)
        {
            for (int i = 0; i < squareSize / 2; i++)
            {
                Console.WriteLine();
                Console.Write("  ");
                for (int col = 0; col < 2; col++)
                {
                    Console.BackgroundColor = colors[row * 2 + col];
                    Console.ForegroundColor = colors[row * 2 + col];
                    for (int j = 0; j < squareSize; j++) Console.Write('@');
                    Console.ResetColor();
                }
            }
        }
        Console.WriteLine();
    }

    private static void DrawLinux()
    {
        Console.WriteLine("Hello, Linux...");

        const string Penguin = @"
                                                     
                        @@@@@                        
                      @@@@@@@@@@                     
                    @@@@@@@@@@@@@                    
                    @@@@@@@@@@@@@@                   
                   @@@@@@@@@@@@@@@@                  
                   @@@@@@@@@@@@@@@@                  
                   @@@@@@@@@@@@@@@@@                 
                  @@@@@@@@@@@@@@@@@@                 
                  @@@@@@@@@@@@@@@@@@                 
                  @@@ @@@@@@@  @@@@@                 
                  @@   @@@@    @@@@@                 
                  @@ @@ @@  @@  @@@@                 
                  @@ @@ @@@ @@@ @@@@                 
                   @ @@---- @@@ @@@@                 
                   @ @-------@  @@@@@                
                   @------------@@@@@                
                   @------------@@@@@                
                   @------------@@@@@                
                   @------------@@@@@                
                   @ ---------  @@@@@@               
                   @  ------    @@@@@@@              
                  @@    --       @@@@@@              
                 @@@             @@@@@@@             
                 @@               @@@@@@             
                @@@               @@@@@@@            
               @@@                 @@@@@@@           
              @@@@                 @@@@@@@@          
             @@@@@                 @@@@@@@@@         
             @@@@@                  @@@@@@@@         
             @@@@                    @@@@@@@@        
            @@@@             *       @@@@@@@@        
            @@@@            ****     @@@@@@@@        
            @@@            *****      @@@@@@@@       
           @@@@     *     ******      @@@@@@@@       
           @@@      **   *** ***      @@@@@@@@       
          @@@@      *******  ***      @@@@@@@@@      
          @@@@      * ****   ***      @@@@@@@@@      
         @@@@@      *******  ***      @@@@@@@@@      
         @@@@@      **   *** ***      @@@@@@@@@      
         @@@@@      *     ******      @@@@@@@@@      
         @@@@@             *****      @@@@@@@@@      
         ---@@              ****      @@@@@@@@       
        -----@@              *      ---@@@@@@@       
        ------@@                   ----@@@@@@--      
   ------------@@                   ---@@@@@@--      
   ------------@@@@                ----@@@@----      
   -------------@@@@               -------------     
   --------------@@@@              --------------    
   --------------@@@@              ---------------   
   ---------------@@@             @----------------  
   ----------------              @@----------------- 
   ----------------             @@@----------------- 
  ------------------          @@@@@----------------  
  ------------------@@     @@@@@@@@--------------    
  -------------------@@@@@@@@@@@@@@------------      
   ------------------@@@@@@@@@@@@@@----------        
      --------------@@@@@@@@@@@@@@@---------         
          @---------@              @-------          
             @----@@               @@-----           
                @@                   @@@             
                                                     
";
        foreach (char c in Penguin)
        {
            if (c == '\n')
            {
                Console.ResetColor();
                Console.WriteLine();
            }
            else
            {
                ConsoleColor cc =
                    c == '*' ? ConsoleColor.Blue :
                    c == '@' ? ConsoleColor.Black :
                    c == '-' ? ConsoleColor.Yellow :
                    ConsoleColor.White;
                Console.BackgroundColor = cc;
                Console.ForegroundColor = cc;
                Console.Write(" ");
            }
        }

        Console.ResetColor();
        Console.WriteLine();
    }

    private static void DrawBbv()
    {
        Console.WriteLine("Hello, Linux...");

        const string Penguin = @"
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM:::::::::::::::::::::::::::MMMMMMMMMMMMMMM\n
MMMMMMMMMMMMMMMMMMMMMMMMMMMM:::::::::MMMMMMMMMMMM:::::::::::::::::MMMMMMMMMM\n
MMMMMMMMMMMMMMMMMMMMMMMM::::MMMMMMMMMMMMMMMMMMMMMMMMMMMMMM:::::::::::::MMMMM\n
MMMMMMMMMMMMMMMMMMMMM:::MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM:::::::::::::\n
MMMMMM@@@@@@MMMMMMM:MMMMMMMMMMM@@@@@@MMMMMMMMMMMMMMMMMMMMMMMMMMMMMM:::::::::\n
MMMMM@@@@@@MMMMMMMMMMMMMMMMMMM@@@@@@MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM:::::\n
MMMMM@@@@@@MMMMMMMMMMMMMMMMMMM@@@@@@MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n
MMMMO@@@@@@MMMMMMMMMMMMMMMMMM@@@@@@MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n
MMMM@@@@@@MMMMMMMMMMMMMMMMMMM@@@@@@MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n
MMMM@@@@@@M@@@@@@@@@MMMMMMMM@@@@@@M@@@@@@@@@@MMMMM@@@@@@MMMMMMMMMM@@@@@@MMMM\n
MMM@@@@@@@@@@@@@@@@@@@MMMMMM@@@@@@@@@@@@@@@@@@@MMM@@@@@@MMMMMMMMM@@@@@@MMMMM\n
MMM@@@@@@MMMMMMMM@@@@@@MMMMD@@@@@@MMMMMMM7@@@@@MMM=@@@@@MMMMMMMM@@@@@@MMMMMM\n
MM@@@@@@MMMMMMMMM@@@@@MMMMM@@@@@@MMMMMMMMM@@@@@MMMM@@@@@MMMMMMM@@@@@@MMMMMMM\n
MM@@@@@@MMMMMMMM~@@@@@MMMMM@@@@@@MMMMMMMM@@@@@OMMMM@@@@@MMMMMM@@@@@@MMMMMMMM\n
MM@@@@@MMMMMMMMM@@@@@@MMMM@@@@@@MMMMMMMMM@@@@@MMMMM@@@@@MMMMM@@@@@@MMMMMMMMM\n
M@@@@@@MMMMMMMMM@@@@@MMMMM@@@@@@MMMMMMMM@@@@@@MMMMMM@@@@@MMM@@@@@@MMMMMMMMMM\n
M@@@@@8MMMMMMMM@@@@@@MMMM@@@@@@MMMMMMMMM@@@@@MMMMMMM@@@@@MM@@@@@@MMMMMMMMMMM\n
@@@@@@MMMMMMMMM@@@@@MMMMM@@@@@@MMMMMMMM@@@@@@MMMMMMM@@@@@M@@@@@@MMMMMMMMMMMM\n
@@@@@@MMMMMMMM@@@@@@MMMMM@@@@@@MMMMMMM@@@@@@MMMMMMMM@@@@@@@@@@@MMMMMMMMMMMMM\n
@@@@@@@MMMMM@@@@@@@MMMMMM@@@@@@@MMMMM@@@@@@MMMMMMMMMM@@@@@@@@@MMMMMMMMMMMMMM\n
@@@@@@@@@@@@@@@@@MMMMMMMM@@@@@@@@@@@@@@@@@MMMMMMMMMMM@@@@@@@@MMMMMMMMMMMMMMM\n
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM\n"
;
        foreach (char c in Penguin)
        {
            if (c == '\n')
            {
                Console.ResetColor();
                Console.WriteLine();
            }
            else
            {
                ConsoleColor cc =
                    c == '@' ? ConsoleColor.Black :
                    c == ':' ? ConsoleColor.Red :
                    ConsoleColor.White;
                Console.BackgroundColor = cc;
                Console.ForegroundColor = cc;
                Console.Write(" ");
            }
        }

        Console.ResetColor();
        Console.WriteLine();
    }

    private static void DrawFreeBSD()
    {
        Console.WriteLine("Hello, FreeBSD...");

        // The FreeBSD Daemon is licensed according to the following terms:

        /*-
         * Copyright (c) 1997 Sandro Sigala, Brescia, Italy.
         * Copyright (c) 1997 Chris Shenton
         * Copyright (c) 1995 S ren Schmidt
         * All rights reserved.
         *
         * Redistribution and use in source and binary forms, with or without
         * modification, are permitted provided that the following conditions
         * are met:
         * 1. Redistributions of source code must retain the above copyright
         *    notice, this list of conditions and the following disclaimer
         *    in this position and unchanged.
         * 2. Redistributions in binary form must reproduce the above copyright
         *    notice, this list of conditions and the following disclaimer in the
         *    documentation and/or other materials provided with the distribution.
         *
         * THIS SOFTWARE IS PROVIDED BY THE AUTHOR ``AS IS'' AND ANY EXPRESS OR
         * IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
         * OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
         * IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY DIRECT, INDIRECT,
         * INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
         * NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
         * DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
         * THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
         * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
         * THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
         */

        const string daemon_pic = @"
               ,        ,
              /(        )`
              \ \___   / |
              /- _  `-/  '
             (/\/ \ \   /\
             / /   | `    \
             O O   ) /    |
             `-^--'`<     '
            (_.)  _  )   /
             `.___/`    /
               `-----' /
  <----.     __ / __   \
  <----|====O)))==) \) /====
  <----'    `--' `.__,' \
               |        |
                \       /       /\
           ______( (_  / \______/
         ,'  ,-----'   |
         `--{__________)
";

        const string daemon_attr = @"
               R        R
              RR        RR
              R RRRR   R R
              RR W  RRR  R
             RWWW W R   RR
             W W   W R    R
             B B   W R    R
             WWWWWWRR     R
            RRRR  R  R   R
             RRRRRRR    R
               RRRRRRR R
  YYYYYY     RR R RR   R
  YYYYYYYYYYRRRRYYR RR RYYYY
  YYYYYY    RRRR RRRRRR R
               R        R
                R       R       RR
           CCCCCCR RR  R RRRRRRRR
         CC  CCCCCCC   C
         CCCCCCCCCCCCCCC
";

        for (int i = 0; i < daemon_pic.Length; i++)
        {
            var symbol = daemon_pic[i];
            var attr = daemon_attr[i];

            ConsoleColor color =
                attr == 'R' ? ConsoleColor.Red :
                attr == 'W' ? ConsoleColor.White :
                attr == 'B' ? ConsoleColor.Blue :
                attr == 'Y' ? ConsoleColor.Yellow :
                attr == 'C' ? ConsoleColor.Cyan :
                ConsoleColor.White;

            Console.ForegroundColor = color;
            Console.Write(symbol);
        }

        Console.ResetColor();
        Console.WriteLine();
    }

    private static void DrawMac()
    {
        Console.WriteLine("Hello, Mac...");

        const string Apple = @"
                                  @@@@ 
                               @@@@@@
                             @@@@@@@@
                           @@@@@@@@@
                          @@@@@@@@@
                         @@@@@@@@
                          @@@@
                          
          @@@@@@@@@@@         @@@@@@@@@@@@@
       @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
     @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
 @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
 @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
 @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
 @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
 @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
 @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
 @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
 @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
    @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
     @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
      @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
       @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
         @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
           @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
             @@@@@@@             @@@@@@@";


        foreach (char c in Apple)
        {
            if (c == '@')
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" ");
            }
            else
            {
                Console.ResetColor();
                Console.Write(c);
            }

        }

        Console.ResetColor();
        Console.WriteLine();
    }
}
