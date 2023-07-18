using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Damage
{
    public class Program           // 입력값에 따른 3가지의 랜덤 데미지 입히기 시스템
    {
        static void Main(string[] args)
        {
            int maxHp = 100;             // 최대 HP
            int hp;                      // 계산할 HP
            int dmg;                     // 데미지
            int userPower;               // 입력값을 받을 데미지 값

            Console.WriteLine("1 ~ 3 사이의 숫자를 입력하시오 => ");        // 유저로부터 랜덤한 데미지값을 받음
            int.TryParse(Console.ReadLine(), out userPower);            // 입력값을 userPower로 변환

            dmg = 40 * userPower;            // 입력값에 40을 곱해준다.
            hp = maxHp - dmg;                // hp에 데미지를 뺀다.

            if (hp > 0)            // 남은 hp 계산
            {
                Console.WriteLine("가한 데미지 : {0}, 남은 HP : {1}", dmg, hp);       // HP가 0보다 크면 데미지와 남은 HP를 출력한다.
            }
            else
            {
                Console.WriteLine("사망하였습니다. 가한 데미지 : {0}", dmg);            // HP가 0보다 작으면 데미지를 출력한다.
            }
        }
    }
}
