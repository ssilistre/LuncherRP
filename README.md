# LuncherRP
Fivem C# using this code:
 
    public void closeFivem()
            {
                try
                {
                    foreach (var process in Process.GetProcessesByName("FiveM"))
                    {
                        process.Kill();
                    }
                }
                catch (Exception)
                {         
                }
            }
            public void connectFivem(string ipNumber ,string portNumber)
            {
                open("fivem://connect/" + ipNumber + ":"+ portNumber);
            }
            public void open(string link)
            {
                    System.Diagnostics.Process.Start(link);
            
      }
      public void teamspeak(string ip)
       {
         open("ts3server://" + ip);
       }
            public void discod(string invitelink)
            {
                open(invitelink);  
         }
