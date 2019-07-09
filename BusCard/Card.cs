using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusCard
{
    public class Card
    {
        private long _id;
        private long _wallet;
        private bool _isTravel=false;
        private DateTime _startTime;
        private DateTime _endTime;
        private string _status;

        public Card() {
            RandomGenerator generator = new RandomGenerator();
            _id = generator.RandomNumber(10000, 99999);
                }
        public void SetCard(long wallet, bool isTravel, string status)
        {
            _wallet = wallet;
            _isTravel = isTravel;
            _status = status;
            if (_isTravel == true)
            {
                _startTime = DateTime.Now;
                _endTime = _startTime.AddMonths(1);
            }
        }
    }
}
