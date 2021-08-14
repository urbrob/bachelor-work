Rails.application.routes.draw do
  root "shopping#index"

  resources :shopping
end
