/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if !ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Geometry
{
    public class AccelWithCovariance : Message
    {
        public const string RosMessageName = "geometry_msgs/AccelWithCovariance";

        //  This expresses acceleration in free space with uncertainty.
        public Accel accel { get; set; }
        //  Row-major representation of the 6x6 covariance matrix
        //  The orientation parameters use a fixed-axis representation.
        //  In order, the parameters are:
        //  (x, y, z, rotation about X axis, rotation about Y axis, rotation about Z axis)
        public double[] covariance { get; set; }

        public AccelWithCovariance()
        {
            this.accel = new Accel();
            this.covariance = new double[36];
        }

        public AccelWithCovariance(Accel accel, double[] covariance)
        {
            this.accel = accel;
            this.covariance = covariance;
        }
    }
}
#endif
