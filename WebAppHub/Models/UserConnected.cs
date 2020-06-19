using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppHub.Models
{
    [Table("user_connected")]
    public class UserConnected
    {
        public UserConnected() { }

        public UserConnected(string connectedId, DateTime connectedAt, bool status)
        {
            ConnectedId = connectedId;
            ConnectedAt = connectedAt;
            Status = status;
        }

        [Key()]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ConnectedId { get; set; }

        [Required()]
        public DateTime ConnectedAt { get; set; }

        [Required()]
        public bool Status { get; set; }

        public static UserConnected Create(string connectedId, DateTime connectedAt, bool status)
        {
            return new UserConnected(connectedId, connectedAt, status);
        }
    }
}
