/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Geometry
{
    public class Wrench : Message
    {
        public const string RosMessageName = "geometry_msgs/msg/Wrench";

        //  This represents force in free space, separated into its linear and angular parts.
        public Vector3 force { get; set; }
        public Vector3 torque { get; set; }

        public Wrench()
        {
            this.force = new Vector3();
            this.torque = new Vector3();
        }

        public Wrench(Vector3 force, Vector3 torque)
        {
            this.force = force;
            this.torque = torque;
        }
    }
}
#endif
