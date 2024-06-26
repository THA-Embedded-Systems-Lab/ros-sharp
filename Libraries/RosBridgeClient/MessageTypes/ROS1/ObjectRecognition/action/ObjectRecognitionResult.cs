/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if !ROS2

using RosSharp.RosBridgeClient.MessageTypes.ObjectRecognition;

namespace RosSharp.RosBridgeClient.MessageTypes.ObjectRecognition
{
    public class ObjectRecognitionResult : Message
    {
        public const string RosMessageName = "object_recognition_msgs/ObjectRecognitionResult";

        //  Send the found objects, see the msg files for docs
        public RecognizedObjectArray recognized_objects { get; set; }

        public ObjectRecognitionResult()
        {
            this.recognized_objects = new RecognizedObjectArray();
        }

        public ObjectRecognitionResult(RecognizedObjectArray recognized_objects)
        {
            this.recognized_objects = recognized_objects;
        }
    }
}
#endif
