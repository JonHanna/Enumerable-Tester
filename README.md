# Enumerable-Tester
This is a simple executable to compare the possible performance benefits of new approaches to some methods in System.Linq.Enumerable.

Results of a run of this tester can be downloaded from [here](Enumerable%20Aggregate Performance.ods?raw=true)

This spreadsheet has been annotated as follows:

Relative improvement is given as a the difference between the new and old times as a percentage of the old time.

Relative improvements of 5% or more have a green background.
Relative improvements of 1–5% have a light green background.
Relative improvements of 0–1% have a very light green background.
Relative deterioration of 5% or more have a red background.
Relative deterioration of 1-5% have a pink background.
Relative deterioration of 0-1% have a light pink background.

Test cases which use a random sequence of more than 1 element are bold, as more likely to represent real data. Those which use an increasing or decreasing sequence are not bold, as more artificial examples intended just to catch if they are a bad worse-case. Those which use empty sequences or sequences of only one element are not bold, as less affected by performance changes.
