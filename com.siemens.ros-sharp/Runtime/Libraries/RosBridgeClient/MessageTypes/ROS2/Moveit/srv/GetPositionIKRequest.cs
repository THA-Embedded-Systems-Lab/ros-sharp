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
    public class GetPositionIKRequest : Message
    {
        public const string RosMessageName = "moveit_msgs/srv/GetPositionIK";

        //  A service call to carry out an inverse kinematics computation
        //  The inverse kinematics request
        public PositionIKRequest ik_request { get; set; }

        public GetPositionIKRequest()
        {
            this.ik_request = new PositionIKRequest();
        }

        public GetPositionIKRequest(PositionIKRequest ik_request)
        {
            this.ik_request = ik_request;
        }
    }
}
#endif