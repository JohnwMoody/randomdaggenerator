var gulp = require('gulp');
var uglify = require('gulp-uglify')


gulp.task('scripts', function () {
    gulp.src(['node_modules/bootstrap/dist/js/bootstrap.min.js',
        'node_modules/jquery/dist/jquery.min.js',
        'node_modules/popper.js/dist/umd/popper.min.js',
        'node_modules/vis/dist/vis.min.js',
        'node_modules/bootstrap-slider/dist/bootstrap-slider.js',
        'node_modules/gasparesganga-jquery-loading-overlay/dist/loadingoverlay.min.js']).pipe(gulp.dest('./dist/scripts'));
});

gulp.task('css', function(){
    gulp.src([
        'node_modules/bootstrap/dist/css/bootstrap.min.css',
        'node_modules/font-awesome/css/font-awesome.min.css',
        'node_modules/vis/dist/vis.min.css',
        'node_modules/bootstrap-slider/dist/css/bootstrap-slider.min.css'
    ]).pipe(gulp.dest('./dist/css'));
})

gulp.task('fonts', function () {
    gulp.src([
        'node_modules/font-awesome/fonts/fontawesome-webfont.eot',
        'node_modules/font-awesome/fonts/fontawesome-webfont.svg',
        'node_modules/font-awesome/fonts/fontawesome-webfont.ttf',
        'node_modules/font-awesome/fonts/fontawesome-webfont.woff',
        'node_modules/font-awesome/fonts/fontawesome-webfont.woff2',
        'node_modules/font-awesome/fonts/fontawesome.otf'
    ]).pipe(gulp.dest('./dist/fonts'))
})

gulp.task('default', ['scripts', 'css', 'fonts']);