﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParkingSlotAPI.Services;
namespace ParkingSlotAPI
{
	public class Calculation
	{

		private DateTime dateTime;
		private int duration;


		public Calculation(DateTime dt, int duration)
		{
			this.dateTime = dt;
			this.duration = duration;

		}

		public List<HoursPerDay> getparkingDay(DateTime startDate, DateTime endDate)
		{
			List<HoursPerDay> result = new  List<HoursPerDay>();
			
			if ((endDate.Day-startDate.Day)==0)
			{

				result.Add(new HoursPerDay(startDate, endDate, getPeriodDuration(startDate, endDate), (int)startDate.DayOfWeek));
				
			}
			else
			{
				DateTime tempStartDate = startDate, AfterCalculation = startDate, BeforeCalculation = startDate;
				double totalSec = getPeriodDuration(startDate, endDate)*60;



				for (int i=0;i<= (endDate - startDate).Days;i++)
				{
					
					if(result.Count==0)
					{
						var remaining = TimeSpan.FromHours(24) - tempStartDate.TimeOfDay;
						AfterCalculation = AfterCalculation.AddSeconds(remaining.TotalSeconds);
						BeforeCalculation = AfterCalculation;
						result.Add(new HoursPerDay(startDate, AfterCalculation, (int)remaining.TotalMinutes, (int)tempStartDate.DayOfWeek));
						totalSec -= (double)remaining.TotalSeconds;
						
					}
					else if(totalSec > 24*60*60)
					{
						AfterCalculation = AfterCalculation.AddSeconds(24 * 60*60);
						
						result.Add(new HoursPerDay(BeforeCalculation, AfterCalculation, 24*60, (int)BeforeCalculation.DayOfWeek));
						totalSec -= 24 * 60 * 60;
						BeforeCalculation = AfterCalculation;
					}
					else
					{
						AfterCalculation = AfterCalculation.AddSeconds(totalSec);
						result.Add(new HoursPerDay(BeforeCalculation, AfterCalculation, Math.Ceiling(totalSec /60.0), (int)BeforeCalculation.DayOfWeek));
					}
					
			
				}
			}
			return result;
			

		}
	
		public DateTime getDateTime()
		{
			return this.dateTime;
		}
		public void setDateTime(DateTime dt)
		{
			this.dateTime = dt;
		}
		public int getDuration()
		{
			return this.duration;
		}
		public void setDuration(int duration)
		{
			this.duration = duration;

		}
	


		public double calculatePrice( double rate, double min)
		{

			double result = 0;
			double finalDuration = this.duration / min;
				if (finalDuration<1)
			{
				result=  rate;
			}
				else
			{
				int getWholeNumber = (int)finalDuration;
				if ((finalDuration-(double)getWholeNumber) >0)
				{
					result+= rate;
				}
				result += getWholeNumber * rate;
			}
			return Math.Round(result, 2, MidpointRounding.ToEven);

		
		}

		public double getPeriodDuration(DateTime st,DateTime et)
		{
			double result = 0;
			if((et- st).TotalHours<0)
			{
				result=((et - st).TotalMinutes) + (24 * 60);
			}
			else
			{
				result = ((et - st).TotalMinutes);
			}
			return result;
		}
		public double getPeriodDurationBasedOnDayTime(DateTime st, DateTime et)
		{
			double result = 0;
	
			if (st.TimeOfDay.TotalMinutes == 0)
			{
				result = et.TimeOfDay.TotalMinutes - 24 * 60;
			}
			else if (et.TimeOfDay.TotalMinutes == 0)
			{
				result = 24 * 60 - st.TimeOfDay.TotalMinutes;
			}
			else
			{
				result = ((et.TimeOfDay - st.TimeOfDay).TotalMinutes);
			}
				
		//	}
			return result;
		}




	}
}
