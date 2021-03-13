using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace jacky.common.redis
{
   public class RedisTools
    {
        private static  RedisClient redisClient;
        public RedisTools() {
            redisClient = new RedisClient(new RedisEndpoint
            {
                Host = "127.0.0.1",
                Port = 6789
            });
        }
    }
}
