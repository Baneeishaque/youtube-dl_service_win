﻿using System;

namespace youtube_dl_service
{
    public class API
    {
        public static String API_Root = "http_API";

        public static String select_Configuration = "select_Configuration.php";
        public static String select_Tasks = "select_Tasks.php";
        public static String select_Task_gids = "select_Task_gids.php";
        public static String update_Task_gid = "update_Task_gid.php";
        public static String update_Task_current_status = "update_Task_current_status.php";
        public static String update_Host = "update_Host.php";

        public static String get_API(String API_Method)
        {
            return Server_Endpiont.Server_IP_Address+"/"+Server_Endpiont.Server_Application_Root + "/" + API_Root+"/"+API_Method;
        }
    }
}
