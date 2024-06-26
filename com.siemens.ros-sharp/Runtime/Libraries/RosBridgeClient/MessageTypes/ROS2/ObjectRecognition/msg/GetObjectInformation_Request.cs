/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

using RosSharp.RosBridgeClient.MessageTypes.ObjectRecognition;

namespace RosSharp.RosBridgeClient.MessageTypes.ObjectRecognition
{
    public class GetObjectInformation_Request : Message
    {
        public const string RosMessageName = "object_recognition_msgs/msg/GetObjectInformation_Request";

        //  Retrieve extra data from the DB for a given object
        //  The type of the object to retrieve info from
        public ObjectType type { get; set; }

        public GetObjectInformation_Request()
        {
            this.type = new ObjectType();
        }

        public GetObjectInformation_Request(ObjectType type)
        {
            this.type = type;
        }
    }
}
#endif
