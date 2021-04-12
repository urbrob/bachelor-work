from django.contrib import admin
from logic.models import User, Product, Shopping, ProductInCart

class UserPanelAdmin(admin.ModelAdmin):
    exclude = ["created_by"]
    def has_view_permission(self, request, obj=None):
        return True

    def has_add_permission(self, request):
        return True

    def has_change_permission(self, request, obj=None):
        return True

    def has_delete_permission(self, request, obj=None):
        return True

    def has_module_permission(self, request):
        return True

    def get_queryset(self, request):
        qs = super().get_queryset(request)
        if request.user.is_superuser:
            return qs
        return qs.filter(created_by=request.user)

    def save_model(self, request, obj, form, change):
        obj.created_by = request.user
        obj.save()


@admin.register(Product)
class ProductAdmin(UserPanelAdmin):
    pass


@admin.register(Shopping)
class ShoppingAdmin(UserPanelAdmin):
    pass


@admin.register(ProductInCart)
class ProductInCartAdmin(UserPanelAdmin):
    pass
