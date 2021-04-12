from django.contrib.auth.views import LogoutView
from django.urls import include, path
from django.conf import settings
from django.contrib import admin
from logic import views

urlpatterns = [
    path('admin/', admin.site.urls, name='administrator'),
    path('', include('social_django.urls', namespace='social')),
    path(
        'logout/',
        LogoutView.as_view(template_name=settings.LOGOUT_REDIRECT_URL),
        name='logout'
        ),
    path('manage/', views.manage, name='manage'),
]
