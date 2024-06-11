/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if !ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Actionlib
{
    public class TwoIntsGoal : Message
    {
        public const string RosMessageName = "actionlib/TwoIntsGoal";

        //  ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
        public long a { get; set; }
        public long b { get; set; }

        public TwoIntsGoal()
        {
            this.a = 0;
            this.b = 0;
        }

        public TwoIntsGoal(long a, long b)
        {
            this.a = a;
            this.b = b;
        }
    }
}
#endif