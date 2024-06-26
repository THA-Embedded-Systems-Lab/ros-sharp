/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if !ROS2

using RosSharp.RosBridgeClient.MessageTypes.Geometry;

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class CartesianPoint : Message
    {
        public const string RosMessageName = "moveit_msgs/CartesianPoint";

        //  This message defines a point in a cartesian trajectory
        public Pose pose { get; set; }
        public Twist velocity { get; set; }
        public Accel acceleration { get; set; }

        public CartesianPoint()
        {
            this.pose = new Pose();
            this.velocity = new Twist();
            this.acceleration = new Accel();
        }

        public CartesianPoint(Pose pose, Twist velocity, Accel acceleration)
        {
            this.pose = pose;
            this.velocity = velocity;
            this.acceleration = acceleration;
        }
    }
}
#endif
