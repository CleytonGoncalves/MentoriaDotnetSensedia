
using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Logging;
using Serilog;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace Desafio1.Util
{
    public class Helper
    {
        public static bool SerilogEstaAtivo()
        {
            return Log.Logger.GetType().Name != "SilentLogger";
        }

        public static bool LeuDoSerilogSettingsJson(IConfiguration cfg)
        {
            return ((IConfigurationRoot) cfg).Providers.OfType<JsonConfigurationProvider>().Any(x => x.Source.Path == "serilogsettings.json");
        }

        public static void LogExtraSerilog()
        {
            if (! SerilogEstaAtivo())
                throw new Exception("Tentiva de logar p/ Serilog sem ele estar ativo");

            Log.Verbose(@"
                ##############################################################
                 ________   ____  ____   _________   _______           _       
                |_   __  | |_  _||_  _| |  _   _  | |_   __ \         / \      
                  | |_ \_|   \ \  / /   |_/ | | \_|   | |__) |       / _ \     
                  |  _| _     > `' <        | |       |  __ /       / ___ \    
                 _| |__/ |  _/ /'`\ \_     _| |_     _| |  \ \_   _/ /   \ \_  
                |________| |____||____|   |_____|   |____| |___| |____| |____| 

                ##############################################################
            ");
        }

        public static void LogNiceLogger(ILogger logger)
        {
            logger.LogTrace(@"
                ###########################################
                 ____  _____   _____     ______   ________  
                |_   \|_   _| |_   _|  .' ___  | |_   __  | 
                  |   \ | |     | |   / .'   \_|   | |_ \_| 
                  | |\ \| |     | |   | |          |  _| _  
                 _| |_\   |_   _| |_  \ `.___.'\  _| |__/ | 
                |_____|\____| |_____|  `.____ .' |________| 
                                                           
                ###########################################
            ");
        }
    }
}
