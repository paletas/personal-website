var wisc3 = wisc3 || {};

wisc3.__generateOriginLine = function (value, len) {
    if (len === 0) return [];
    var a = [value];
    while (a.length * 2 <= len) a = a.concat(a);
    if (a.length < len) a = a.concat(a.slice(0, len - a.length));
    return a;
};

wisc3.drawStandardResultsChart = function (element, points) {
    if (wisc3.__standardResulsChartInstance !== undefined)
        wisc3.__standardResulsChartInstance.destroy();

    return wisc3.__standardResulsChartInstance = new Chart(element.getContext('2d'), {
        type: 'line',
        data: {
            labels: points.Labels,
            datasets: [{
                label: 'Origin',
                data: wisc3.__generateOriginLine(10, points.Labels.length),
                fill: false,
                pointBackgroundColor: 'rgba(0, 0, 0, 0)',
                backgroundColor: 'rgba(0, 0, 0, 0)',
                borderColor: 'rgba(0, 0, 0, 0)',
                hoverBackgroundColor: 'rgba(0, 0, 0, 0)',
                hoverBorderColor: 'rgba(0, 0, 0, 0)',
                datalabels: {
                    display: false
                }
            }, {
                label: 'Verbal',
                data: points.Verbal,
                xAxisID: 'testAxis',
                borderColor: 'rgba(0, 0, 255, 1)',
                backgroundColor: 'rgba(0, 0, 255, 0.3)',
                pointBorderColor: 'black',
                pointBackgroundColor: 'black',
                fill: 0
            }, {
                label: 'Realização',
                data: points.Realization,
                xAxisID: 'testAxis',
                borderColor: 'rgba(65, 105, 225, 1)',
                backgroundColor: 'rgba(65, 105, 225, 0.3)',
                pointBorderColor: 'black',
                pointBackgroundColor: 'black',
                fill: 0
            }]
        },
        options: {
            maintainAspectRatio: true,
            responsive: true,
            scales: {
                xAxes: [{
                    id: 'testAxis',
                    type: 'category',
                    position: 'top',
                    gridLines: {
                        drawTicks: true,
                        drawBorder: true,
                        drawOnChartArea: false,
                        offsetGridLines: true
                    },
                    ticks: {
                        padding: 5,
                        beginAtZero: true
                    }
                }],
                yAxes: [{
                    position: 'left',
                    gridLines: {
                        drawTicks: true,
                        drawBorder: true,
                        drawOnChartArea: false,
                        offsetGridLines: true
                    },
                    ticks: {
                        min: 1,
                        max: 19,
                        stepSize: 1,
                        padding: 5
                    }
                }]
            },
            layout: {
                padding: {
                    top: 60
                }
            },
            tooltips: {
                filter: function (tooltip) {
                    return tooltip.datasetIndex !== 0;
                }
            },
            annotation: {
                drawTime: 'afterDraw',
                annotations: [{
                    type: 'box',
                    xScaleID: 'testAxis',
                    yScaleID: 'y-axis-0',
                    yMin: 9.5,
                    yMax: 10.5,
                    borderColor: 'rgba(0, 0, 0, 0.1)',
                    backgroundColor: 'rgba(0, 0, 0, 0.1)'
                }]
            },
            plugins: {
                datalabels: {
                    backgroundColor: function (context) {
                        return context.dataset.backgroundColor;
                    },
                    borderRadius: 4,
                    color: 'white',
                    font: {
                        weight: 'bold'
                    }
                }
            }
        }
    });
};

wisc3.drawStandardFactorialIndicesChart = function (element, points) {
    if (wisc3.__standardFactorialIndicesChartInstance !== undefined)
        wisc3.__standardFactorialIndicesChartInstance.destroy();

    return wisc3.__standardFactorialIndicesChartInstance = new Chart(element.getContext('2d'), {
        type: 'line',
        data: {
            labels: points.Labels,
            datasets: [{
                label: 'Origin',
                data: wisc3.__generateOriginLine(10, points.Labels.length),
                fill: false,
                pointBackgroundColor: 'rgba(0, 0, 0, 0)',
                backgroundColor: 'rgba(0, 0, 0, 0)',
                borderColor: 'rgba(0, 0, 0, 0)',
                hoverBackgroundColor: 'rgba(0, 0, 0, 0)',
                hoverBorderColor: 'rgba(0, 0, 0, 0)',
                datalabels: {
                    display: false
                },
                tooltips: {
                    enabled: false
                }
            }, {
                label: 'Compreensão Verbal',
                data: points.VerbalComprehension,
                xAxisID: 'testAxis',
                borderColor: 'rgba(0, 100, 0, 1)',
                backgroundColor: 'rgba(0, 100, 0, 0.3)',
                pointBorderColor: 'black',
                pointBackgroundColor: 'black',
                fill: 0
            }, {
                label: 'Organização Perceptiva',
                data: points.PerceptiveOrganization,
                xAxisID: 'testAxis',
                borderColor: 'rgba(0, 128, 0, 1)',
                backgroundColor: 'rgba(0, 128, 0, 0.3)',
                pointBorderColor: 'black',
                pointBackgroundColor: 'black',
                fill: 0
            }, {
                label: 'Velocidade Processamento',
                data: points.ProcessingVelocity,
                xAxisID: 'testAxis',
                borderColor: 'rgba(107, 142, 35, 1)',
                backgroundColor: 'rgba(107, 142, 35, 0.3)',
                pointBorderColor: 'black',
                pointBackgroundColor: 'black',
                fill: 0
            }]
        },
        options: {
            maintainAspectRatio: true,
            responsive: true,
            scales: {
                xAxes: [{
                    id: 'testAxis',
                    type: 'category',
                    position: 'top',
                    gridLines: {
                        drawTicks: true,
                        drawBorder: true,
                        drawOnChartArea: false,
                        offsetGridLines: true
                    },
                    ticks: {
                        padding: 5,
                        beginAtZero: true
                    }
                }],
                yAxes: [{
                    position: 'left',
                    gridLines: {
                        drawTicks: true,
                        drawBorder: true,
                        drawOnChartArea: false,
                        offsetGridLines: true
                    },
                    ticks: {
                        min: 1,
                        max: 19,
                        stepSize: 1,
                        padding: 5
                    }
                }]
            },
            layout: {
                padding: {
                    top: 60
                }
            },
            tooltips: {
                filter: function (tooltip) {
                    return tooltip.datasetIndex !== 0;
                }
            },
            annotation: {
                drawTime: 'afterDraw',
                annotations: [{
                    type: 'box',
                    xScaleID: 'testAxis',
                    yScaleID: 'y-axis-0',
                    yMin: 9.5,
                    yMax: 10.5,
                    borderColor: 'rgba(0, 0, 0, 0.1)',
                    backgroundColor: 'rgba(0, 0, 0, 0.1)'
                }]
            },
            plugins: {
                datalabels: {
                    backgroundColor: function (context) {
                        return context.dataset.backgroundColor;
                    },
                    borderRadius: 4,
                    color: 'white',
                    font: {
                        weight: 'bold'
                    }
                }
            }
        }
    });
};

wisc3.drawQiResultsChart = function (element, points) {
    if (wisc3.__qiResultsChartInstance !== undefined)
        wisc3.__qiResultsChartInstance.destroy();

    return wisc3.__qiResultsChartInstance = new Chart(element.getContext('2d'), {
        type: 'boxplot',
        data: {
            labels: points.QI.map(qi => qi.label).concat(points.Indices.map(ix => ix.label)),
            datasets: [{
                label: 'QI',
                backgroundColor: 'rgba(255,0,0,0.2)',
                borderColor: 'red',
                borderWidth: 1,
                outlierColor: '#999999',
                padding: 10,
                itemRadius: 2,
                itemStyle: 'circle',
                itemBackgroundColor: '#000',
                data: points.QI.concat(new Array(points.Indices.length)),
                datalabels: {
                    anchor: 'end',
                    align: 'top'
                }
            }, {
                label: 'Indices',
                backgroundColor: 'rgba(0,0,255,0.2)',
                borderColor: 'blue',
                borderWidth: 1,
                outlierColor: '#999999',
                padding: 10,
                itemRadius: 2,
                itemStyle: 'circle',
                itemBackgroundColor: '#000',
                data: new Array(points.QI.length).concat(points.Indices),
                datalabels: {
                    anchor: 'end',
                    align: 'top'
                }
            }]
        },
        options: {
            scales: {
                xAxes: [{
                    ticks: {
                        display: false
                    }
                }],
                yAxes: [{
                    ticks: {
                        suggestedMax: 195,
                        stepSize: 5,
                        callback: function (value, index, values) {
                            if (index === values.length || value % 10 === 0) return value;
                            else return null;
                        },
                        autoSkip: false
                    }
                }]
            },
            annotation: {
                drawTime: 'afterDraw',
                annotations: [{
                    type: 'box',
                    xScaleID: 'testAxis',
                    yScaleID: 'y-axis-0',
                    yMin: 99.5,
                    yMax: 100.5,
                    borderColor: 'rgba(0, 0, 0, 0.1)',
                    backgroundColor: 'rgba(0, 0, 0, 0.1)'
                }]
            },
            plugins: {
                datalabels: {
                    backgroundColor: function (context) {
                        return context.dataset.backgroundColor;
                    },
                    borderRadius: 4,
                    color: 'white',
                    font: {
                        weight: 'bold'
                    }
                }
            }
        }
    });
};