module.exports = function (grunt) {

    grunt.initConfig({
        bowercopy: {
            options: {
                // Bower components folder will be removed afterwards 
                clean: false
            },
            // Javascript 
            javascript: {
                options: {
                    destPrefix: 'js'
                },
                files: {
                    libs: ['angular/angular.min.js',
                        'angular-ui-router/release/angular-ui-router.min.js',
                        'jquery/dist/jquery.min.js',
                        'angular-datatables/dist/angular-datatables.min.js',
                        'datatables/media/js/jquery.dataTables.min.js']
                }
            },
            css: {
                options: {
                    destPrefix: 'css'
                },
                files: {
                    libs: ['angular-datatables/dist/css/angular-datatables.min.css']
                }
            }
        }
    });

    grunt.loadNpmTasks('grunt-bowercopy');

    grunt.registerTask('default', []);
};