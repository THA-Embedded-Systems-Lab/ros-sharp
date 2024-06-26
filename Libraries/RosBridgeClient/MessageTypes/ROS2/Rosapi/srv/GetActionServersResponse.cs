/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Rosapi
{
    public class GetActionServersResponse : Message
    {
        public const string RosMessageName = "rosapi_msgs/srv/GetActionServers";

        public string[] action_servers { get; set; }

        public GetActionServersResponse()
        {
            this.action_servers = new string[0];
        }

        public GetActionServersResponse(string[] action_servers)
        {
            this.action_servers = action_servers;
        }
    }
}
#endif
