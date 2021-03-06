# PendAdvisor
A hypothetical ML predictor to advise on the action to take on a pended medical claim.

## Installation

* Fork this repository and clone it onto your local machine, or

* Download this repository onto your local machine.

## PendAdvisor ML Model

The ML model depicted in this solution reflects an oversimiplified medical claim scenario.
It is provided solely for demonstration purposes and is not intended as illustration of
any medical claims processing system.

Model input accepts the following claim attributes. Note that only those attributes
marked with an asterisk play role in the ML prediction.

* MemberID
* ClaimID
* DateReceived
* providerNPI
* Diagnosis1*
* Diagnosis2*
* POS*
* ProcedureCode*
* Units*
* Price*
* PendReason*

Model output provides a recommended action for the claim, which can be one of:

- Release
- Deny
- Reprocess
- MedReview

More specifically, the output contains an array with the 4 possible actions and their
associated scores. Each score is a value between 0 and 1. The recommended (predicted)
action is the one with the highest score. The higher score value, the better odds that
the prediction is correct. The total of all score values is always 1.

## Projects Descriptions

The PendAdvision solution consists of the following projects:

1. **PendAdvisorModel**. A class library that contains the ML model and the prediction engine.
2. **PendAdvisorModel.Tests**. Unit tests for the PendAdvisorModel project.
3. **PendAdvisorTrainer**. A console application to train the ML model by consumming an arbitrary
set of claims.
4. **PendAdvisor.API**. A simple Web API that exposes REST API to accept http POST requests with
claim data (ML Model inputs) and return htttp responses with corresponding recommendations (ML Model outputs).
5. **PendAdvisorTester**. A console application that consumes an arbitrary set (batch) of test claims and
provides a set of corresponding predictions.
6. **PendAdvisorClient**. A desktop application (WinForms) and an http client that consumes REST API
(like the one exposed by PendAdvisor.API) to obtain recommended actions for pended medical claims.

Note that PendAdvisor.API and PendAdvisorTester projects directly depend on the prediction engine
implemented in PendAdvisorModel project. The engine runtime requires access to the
trained model (MLModel.zip file), which is generated with each execution of PendAdvisorTrainer project.
Therefore, in order for the newly trained model to be in effect, the PendAdvisor.API and PendAdvisorTester
projects MUST BE REBUILT every time the ML model is trained, i.e. after running PendAdvisorTrainer.exe.

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License

[Apache License 2.0](https://choosealicense.com/licenses/apache-2.0/)

## Copyright

```
Copyright � 2020-2021 Mavidian Technologies Limited Liability Company. All Rights Reserved.
```

