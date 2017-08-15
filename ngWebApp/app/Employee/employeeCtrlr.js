ngFormsApp.controller('employeeCtrlr',
    function employeeCtrlr($scope, employeeSrvc) {
        //debugger;
        $scope.employee = employeeSrvc.employee;

        $scope.departments = [
            "Engineering",
            "Marketing",
            "Finance",
            "Administration"
        ];

        $scope.submitForm = function () {
            alert('Yahoo!');
        }
    });