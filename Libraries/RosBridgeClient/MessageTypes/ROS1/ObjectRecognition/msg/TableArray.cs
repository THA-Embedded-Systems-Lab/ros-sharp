/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if !ROS2

using RosSharp.RosBridgeClient.MessageTypes.Std;
using RosSharp.RosBridgeClient.MessageTypes.ObjectRecognition;

namespace RosSharp.RosBridgeClient.MessageTypes.ObjectRecognition
{
    public class TableArray : Message
    {
        public const string RosMessageName = "object_recognition_msgs/TableArray";

        public Header header { get; set; }
        //  Just an array of tables
        public Table[] tables { get; set; }

        public TableArray()
        {
            this.header = new Header();
            this.tables = new Table[0];
        }

        public TableArray(Header header, Table[] tables)
        {
            this.header = header;
            this.tables = tables;
        }
    }
}
#endif
