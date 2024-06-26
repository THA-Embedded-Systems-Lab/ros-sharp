/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if !ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class ExecuteTrajectoryGoal : Message
    {
        public const string RosMessageName = "moveit_msgs/ExecuteTrajectoryGoal";

        //  The trajectory to execute
        public RobotTrajectory trajectory { get; set; }

        public ExecuteTrajectoryGoal()
        {
            this.trajectory = new RobotTrajectory();
        }

        public ExecuteTrajectoryGoal(RobotTrajectory trajectory)
        {
            this.trajectory = trajectory;
        }
    }
}
#endif
