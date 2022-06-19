/// <binding BeforeBuild='clean' AfterBuild='css' Clean='clean' ProjectOpened='watch' />
const gulp = require('gulp');

gulp.task('clean', () => {
    const clean = require('gulp-clean');

    return gulp.src('wwwwroot/css/*.css', { read: false }).pipe(clean());
});

gulp.task('css', () => {
    const postcss = require('gulp-postcss');
    const flatten = require('gulp-flatten');
    const rename = require('gulp-rename');

    return gulp.src('./wwwroot/css/tailwind.css')
        .pipe(postcss([
            require('precss'),
            require('tailwindcss'),
            require('autoprefixer')
        ]))
        .pipe(flatten())
        .pipe(rename('site.css'))
        .pipe(gulp.dest('wwwroot/css'));
});

gulp.task('watch', () => {
    return gulp.watch('./wwwwroot/css/tailwind.css', { delay: 500 }, gulp.series(['clean', 'css']));
});