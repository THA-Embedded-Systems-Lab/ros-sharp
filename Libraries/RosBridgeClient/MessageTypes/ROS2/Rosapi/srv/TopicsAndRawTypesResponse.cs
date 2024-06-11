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
    public class TopicsAndRawTypesResponse : Message
    {
        public const string RosMessageName = "rosapi_msgs/srv/TopicsAndRawTypes";

        public string[] topics { get; set; }
        public string[] types { get; set; }
        public string[] typedefs_full_text { get; set; }

        public TopicsAndRawTypesResponse()
        {
            this.topics = new string[0];
            this.types = new string[0];
            this.typedefs_full_text = new string[0];
        }

        public TopicsAndRawTypesResponse(string[] topics, string[] types, string[] typedefs_full_text)
        {
            this.topics = topics;
            this.types = types;
            this.typedefs_full_text = typedefs_full_text;
        }
    }
}
#endif