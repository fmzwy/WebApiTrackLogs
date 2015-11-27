namespace WebApiTrackLog.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TrackLogEntities : DbContext
    {
        public TrackLogEntities()
            : base("name=TrackLogEntities")
        {
        }
        /// <summary>
        /// webapi�����¼ʵ��
        /// </summary>
        public IDbSet<WepApiActionLog> WepApiActionLogs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
