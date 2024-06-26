/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.UniqueIdentifier
{
    public class UUID : Message
    {
        public const string RosMessageName = "unique_identifier_msgs/msg/UUID";

        //  A universally unique identifier (UUID).
        // 
        //   http://en.wikipedia.org/wiki/Universally_unique_identifier
        //   http://tools.ietf.org/html/rfc4122.html
        public byte[] uuid { get; set; }

        public UUID()
        {
            this.uuid = new byte[16];
        }

        public UUID(byte[] uuid)
        {
            this.uuid = uuid;
        }
    }
}
#endif
