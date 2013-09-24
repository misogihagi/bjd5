﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiServer {
    public class Config {
        //サーバの起動・停止
        public bool Service { get; set; }
        
        public Config(){
            Init();
        }

        //デフォルト値での初期化
        public void Init(){
            Service = true; 
        }

    }
}
