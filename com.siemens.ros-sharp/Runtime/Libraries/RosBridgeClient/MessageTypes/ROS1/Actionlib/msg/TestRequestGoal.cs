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

namespace RosSharp.RosBridgeClient.MessageTypes.Actionlib
{
    public class TestRequestGoal : Message
    {
        public const string RosMessageName = "actionlib/TestRequestGoal";

        //  ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
        public const int TERMINATE_SUCCESS = 0;
        public const int TERMINATE_ABORTED = 1;
        public const int TERMINATE_REJECTED = 2;
        public const int TERMINATE_LOSE = 3;
        public const int TERMINATE_DROP = 4;
        public const int TERMINATE_EXCEPTION = 5;
        public int terminate_status { get; set; }
        public bool ignore_cancel { get; set; }
        //  If true, ignores requests to cancel
        public string result_text { get; set; }
        public int the_result { get; set; }
        //  Desired value for the_result in the Result
        public bool is_simple_client { get; set; }
        public Duration delay_accept { get; set; }
        //  Delays accepting the goal by this amount of time
        public Duration delay_terminate { get; set; }
        //  Delays terminating for this amount of time
        public Duration pause_status { get; set; }
        //  Pauses the status messages for this amount of time

        public TestRequestGoal()
        {
            this.terminate_status = 0;
            this.ignore_cancel = false;
            this.result_text = "";
            this.the_result = 0;
            this.is_simple_client = false;
            this.delay_accept = new Duration();
            this.delay_terminate = new Duration();
            this.pause_status = new Duration();
        }

        public TestRequestGoal(int terminate_status, bool ignore_cancel, string result_text, int the_result, bool is_simple_client, Duration delay_accept, Duration delay_terminate, Duration pause_status)
        {
            this.terminate_status = terminate_status;
            this.ignore_cancel = ignore_cancel;
            this.result_text = result_text;
            this.the_result = the_result;
            this.is_simple_client = is_simple_client;
            this.delay_accept = delay_accept;
            this.delay_terminate = delay_terminate;
            this.pause_status = pause_status;
        }
    }
}
#endif
