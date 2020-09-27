/// <binding AfterBuild='build' Clean='clean' ProjectOpened='clean, build' />
'use strict';

var paths = {
    minCss: "./wwwroot/css/"
};

var gulp = require('gulp'),
    rimraf = require('rimraf'),
    sass = require('gulp-sass'),
    cssmin = require('gulp-clean-css'),
    rename = require('gulp-rename');

gulp.task('clean:css', function () {
    return rimraf(['wwwroot/lib/bootstrap/**.*']);
});

gulp.task('clean', gulp.series('clean:css'));

gulp.task('bootstrap:sass', function () {
    return gulp.src(['./node_modules/bootstrap/scss/bootstrap.scss', "!" + paths.minCss])
        .pipe(sass())
        .pipe(gulp.dest('./wwwroot/lib/bootstrap/'))
        .pipe(cssmin())
        .pipe(rename({ suffix: '.min' }))
        .pipe(gulp.dest('./wwwroot/lib/bootstrap/'));
});

gulp.task('build', gulp.series('bootstrap:sass'));