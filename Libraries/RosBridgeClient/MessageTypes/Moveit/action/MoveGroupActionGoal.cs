/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using RosSharp.RosBridgeClient.MessageTypes.Std;
using RosSharp.RosBridgeClient.MessageTypes.Actionlib;

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class MoveGroupActionGoal : ActionGoal<MoveGroupGoal>
    {
        public const string RosMessageName = "moveit_msgs/MoveGroupActionGoal";

        public MoveGroupActionGoal() : base()
        {
            this.goal = new MoveGroupGoal();
        }

        public MoveGroupActionGoal(Header header, GoalID goal_id, MoveGroupGoal goal) : base(header, goal_id)
        {
            this.goal = goal;
        }
    }
}