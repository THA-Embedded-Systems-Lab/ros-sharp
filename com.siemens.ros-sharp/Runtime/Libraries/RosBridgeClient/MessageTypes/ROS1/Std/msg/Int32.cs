/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if !ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Std
{
    public class Int32 : Message
    {
        public const string RosMessageName = "std_msgs/Int32";

        public int data { get; set; }

        public Int32()
        {
            this.data = 0;
        }

        public Int32(int data)
        {
            this.data = data;
        }
    }
}
#endif