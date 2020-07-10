using Vector2 = UnityEngine.Vector2; 

namespace HexUN.Pawn
{
    /// <summary>
    /// Controls for a character controller 2D
    /// </summary>
    public interface IPhysicsPawn2DControl : IPhysicsPawn2DProvider
    {
        /// <summary>
        /// On the frame that move is called, a velocity change equal to
        /// the amount. Should be a vector with magnitude between 0 and 1
        /// </summary>
        /// <param name="amount"></param>
        void Move(Vector2 amount);

        /// <summary>
        /// On the frame that impulse is called, applies a force to the 
        /// character based on mass. The direction is normalized and the 
        /// magnitude is used to apply the force. Impulse uses the calculation
        /// force = mass*distance/time
        /// </summary>
        /// <param name="amount"></param>
        void Impluse(Vector2 direction, float force);

        /// <summary>
        /// Maintains a contant base velocity on the ridgidbody in a direction
        /// over time. Direction is normalized, velocity represents the velocity
        /// in units/second, time is the amount of time the dash lasts
        /// </summary>
        /// <param name="amount"></param>
        void Dash(Vector2 direction, float velocity, float time);
    }
}