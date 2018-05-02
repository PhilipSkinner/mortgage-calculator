using System;

namespace mortgage_calculator.Models
{
    public class CalculationRequest {
    	public double? amount;
    	public int? period;
    	public double? interest;

    	public Error isValid() {
    		if (!this.amount.HasValue) {
                return new Error() {
                    code = "0001",
                    message = "Require total borrowing amount in order to calculate mortgage repayments."
                };
            }

            if (!this.period.HasValue) {
                return new Error() {
                    code = "0002",
                    message = "Require period of loan in order to calculate mortgage repayments"
                };
            }

            if (!this.interest.HasValue) {
                return new Error() {
                    code = "0003",
                    message = "Require interest rate in order to calculate mortgage repayments"
                };
            }

            if (this.amount.Value <= 0) {
                return new Error() {
                    code = "1001",
                    message = "Total loan amount must be greater than zero"
                };
            }

            if (this.period.Value <= 0) {
                return new Error() {
                    code = "1002",
                    message = "Period must be greater than zero years"
                };
            }

            if (this.interest.Value <= 0) {
                return new Error() {
                    code = "1003",
                    message = "Interest rate must be greater than zero"
                };
            }

            return null;
    	}
    }
}
