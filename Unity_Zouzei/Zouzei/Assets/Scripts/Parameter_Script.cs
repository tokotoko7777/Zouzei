using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Parameter_Script : MonoBehaviour
{
    public int Okane=0;
    public int[] Happiness=new int[3]{0,0,0};
    public int Taxrate=0;
    public int Year=0;

    public int GetOkane(){
      return Okane;
    }

    public void SetOkane(int set){
      this.Okane=set;
    }

    public int GetHappiness(int who){
      if(who==0){
        return Happiness[0];
      }else if(who==1){
        return Happiness[1];
      }else if(who==2){
        return Happiness[2];
      }else{
        return Happiness[0]+Happiness[1]+Happiness[2];
      }
    }

    public void SetHappiness(int who,int happiness){
      if(who==0){
        Happiness[0]=happiness;
      }else if(who==1){
        Happiness[1]=happiness;
      }else if(who==2){
        Happiness[2]=happiness;
      }
    }


    public int GetTaxrate(){
      return Taxrate;
    }
    public void SetTaxrate(int a){
      this.Taxrate=a;
    }

    public int GetYear(){
      return Year;
    }
    public void YearEnd(){
      this.Year++;
    }
}
