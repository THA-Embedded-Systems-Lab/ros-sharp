/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if !ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Actionlib
{
    public class TestRequestResult : Message
    {
        public const string RosMessageName = "actionlib/TestRequestResult";

        //  ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
        public int the_result { get; set; }
        public bool is_simple_server { get; set; }

        public TestRequestResult()
        {
            this.the_result = 0;
            this.is_simple_server = false;
        }

        public TestRequestResult(int the_result, bool is_simple_server)
        {
            this.the_result = the_result;
            this.is_simple_server = is_simple_server;
        }
    }
}
#endif
