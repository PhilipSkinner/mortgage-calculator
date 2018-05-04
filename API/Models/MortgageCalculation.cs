using System;

namespace mortgage_calculator.Models
{
    public class MortgageCalculation {
    	public double total_cost;
    	public double monthly_payment;

    	public MortgageCalculation(double amount, int period, double interest) {
    		int months = period * 12;
    		double correctedInterest = interest / (100 * 12);
    		
    		this.monthly_payment = Math.Round(amount * (correctedInterest/(1 - Math.Pow(1 + correctedInterest, -months))), 2);
    		this.total_cost = Math.Round(this.monthly_payment * months);
    	}
    }
}
