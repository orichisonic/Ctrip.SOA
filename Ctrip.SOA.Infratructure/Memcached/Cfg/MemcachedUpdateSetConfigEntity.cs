//业务实体
//******************************************************************
//功能:
//
//历史: 2014/1/10 
//说明: 这是由一个工具自动生成的代码
//******************************************************************/
using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
namespace HHInfratructure.Memcached.Cfg
{
    /// <summary>
    /// MemcachedUpdateSetConfig实体类
    /// </summary>
    [Serializable]
    public class MemcachedUpdateSetConfigEntity
    {
		/// <summary>
		/// 缓存Key前缀
		/// </summary>
		public string CacheKeyPrefix { get; set; }
		
		/// <summary>
		/// 缓存更新间隔，单位分钟
		/// </summary>
		public int UpdateHourSpan { get; set; }
		
		/// <summary>
		/// 是否按照分钟触发Job服务
		/// </summary>
		public int IsJobActByMin { get; set; }
		
		/// <summary>
		/// 最小频率控制阀值
		/// </summary>
		public int FreMin { get; set; }
		
		/// <summary>
		/// 数据改变最后时间
		/// </summary>
		public DateTime DataChange_LastTime { get; set; }		
		
        /// <summary>
        /// 根据一条数据记录创建实体对象
        /// </summary>
        public static MemcachedUpdateSetConfigEntity CreateEntity(DataRow dr)
        {
            MemcachedUpdateSetConfigEntity ent = new MemcachedUpdateSetConfigEntity();
            if(dr["CacheKeyPrefix"] != DBNull.Value)ent.CacheKeyPrefix = (string)dr["CacheKeyPrefix"];            
            if(dr["UpdateHourSpan"] != DBNull.Value)ent.UpdateHourSpan = int.Parse(dr["UpdateHourSpan"].ToString());
            if(dr["IsJobActByMin"] != DBNull.Value)ent.IsJobActByMin = int.Parse(dr["IsJobActByMin"].ToString());            
            if(dr["FreMin"] != DBNull.Value)ent.FreMin = int.Parse(dr["FreMin"].ToString());            
            if(dr["DataChange_LastTime"] != DBNull.Value)ent.DataChange_LastTime = DateTime.Parse(dr["DataChange_LastTime"].ToString());
            return ent;
        }
       
        /// <summary>
        /// 根据数据集合创建实体对象集合
        /// </summary>
        public static List<MemcachedUpdateSetConfigEntity> CreateEntity(DataRow[] drs)
        {
            List<MemcachedUpdateSetConfigEntity> ents = new List<MemcachedUpdateSetConfigEntity>();
            foreach (DataRow dr in drs)
            {
                ents.Add(CreateEntity(dr));
            }
            return ents;
        }
       
        /// <summary>
        /// 将当前实体转化成日志记录
        /// </summary>
        public string ConvertEntityToLogString()
        {
            StringBuilder LogDetail = new StringBuilder();
            if (this.CacheKeyPrefix != null)LogDetail.AppendLine("CacheKeyPrefix=" + this.CacheKeyPrefix.ToString());            
            LogDetail.AppendLine("UpdateHourSpan=" + this.UpdateHourSpan.ToString());
            LogDetail.AppendLine("IsJobActByMin=" + this.IsJobActByMin.ToString());            
            LogDetail.AppendLine("FreMin=" + this.FreMin.ToString());            
            LogDetail.AppendLine("DataChange_LastTime=" + this.DataChange_LastTime.ToString());
            return LogDetail.ToString();
        }
       
       
	}
}
