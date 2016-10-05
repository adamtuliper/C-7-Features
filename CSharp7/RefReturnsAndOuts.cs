using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static c_sharp_7.CSharp7.GiganticData;

namespace c_sharp_7.CSharp7
{
    //Large data structure
    public class GiganticData
    {
        public PlayerData PlayerData;
        public EnemyData EnemyData;
    }

    public struct PlayerData
    {
        public int Health;
    }
    public struct EnemyData
    {
        public int Health;
    }

    public class RefReturnsAndOuts
    {
        private GiganticData _data;

        public RefReturnsAndOuts()
        {
            _data = new GiganticData();
            _data.PlayerData.Health = 0x00110011;
            _data.EnemyData.Health = 0x00EE00EE;
        }
        public PlayerData GetPlayerDataNoRef()
        {
            //return a ref to an item in an array.
            return _data.PlayerData;
        }

        public ref PlayerData GetPlayerData()
        {
            //return a ref to an item in an array.
            return ref _data.PlayerData;
        }

        public void TestRefs()
        {

            //EAX contains PTR when done with call (view disassembly)
            ref PlayerData dataRef = ref GetPlayerData();
            dataRef.Health = 10;
            //note disassembly - after call is done EAX contains value
            var dataNoRef = GetPlayerDataNoRef();
        }

    }
}
