﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Service.Monitoring.Config.Generator.Infrastructure
{
    public interface IConfigDeserializer<out T>
    {
        public T Deserialize(Stream stream);
    }
}
