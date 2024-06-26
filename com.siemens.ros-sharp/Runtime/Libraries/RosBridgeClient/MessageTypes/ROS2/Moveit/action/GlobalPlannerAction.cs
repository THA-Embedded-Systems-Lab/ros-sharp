/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2


namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class GlobalPlannerAction : Action<GlobalPlannerActionGoal, GlobalPlannerActionResult, GlobalPlannerActionFeedback, GlobalPlannerGoal, GlobalPlannerResult, GlobalPlannerFeedback>
    {
        public const string RosMessageName = "moveit_msgs/action/GlobalPlannerAction";

        public GlobalPlannerAction() : base()
        {
            this.action_goal = new GlobalPlannerActionGoal();
            this.action_result = new GlobalPlannerActionResult();
            this.action_feedback = new GlobalPlannerActionFeedback();
        }

    }
}
#endif
