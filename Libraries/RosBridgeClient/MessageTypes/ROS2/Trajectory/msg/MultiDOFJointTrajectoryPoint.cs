/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

using RosSharp.RosBridgeClient.MessageTypes.Geometry;
using RosSharp.RosBridgeClient.MessageTypes.BuiltinInterfaces;

namespace RosSharp.RosBridgeClient.MessageTypes.Trajectory
{
    public class MultiDOFJointTrajectoryPoint : Message
    {
        public const string RosMessageName = "trajectory_msgs/msg/MultiDOFJointTrajectoryPoint";

        //  Each multi-dof joint can specify a transform (up to 6 DOF).
        public Transform[] transforms { get; set; }
        //  There can be a velocity specified for the origin of the joint.
        public Twist[] velocities { get; set; }
        //  There can be an acceleration specified for the origin of the joint.
        public Twist[] accelerations { get; set; }
        //  Desired time from the trajectory start to arrive at this trajectory point.
        public Duration time_from_start { get; set; }

        public MultiDOFJointTrajectoryPoint()
        {
            this.transforms = new Transform[0];
            this.velocities = new Twist[0];
            this.accelerations = new Twist[0];
            this.time_from_start = new Duration();
        }

        public MultiDOFJointTrajectoryPoint(Transform[] transforms, Twist[] velocities, Twist[] accelerations, Duration time_from_start)
        {
            this.transforms = transforms;
            this.velocities = velocities;
            this.accelerations = accelerations;
            this.time_from_start = time_from_start;
        }
    }
}
#endif
